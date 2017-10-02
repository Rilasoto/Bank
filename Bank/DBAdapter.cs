﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics;
using System.Data.SqlClient;
using System.Data;

namespace DBAdapter
{
    class DB
    {
        static DB instance;

        //string connectionString = "Data Source=DESKTOP-V4KR3NR;Initial Catalog=ProjectBank;Integrated Security=True";
        SqlConnection connection;

        public DB()
        {
            connection = new SqlConnection("Data Source=DESKTOP-V4KR3NR;Initial Catalog=ProjectBank;Integrated Security=True");//Ринат
            //connection = new SqlConnection("Data Source=DESKTOP-4E4QD9H;Initial Catalog=ProjectBank;Integrated Security=True");//Егор
        }

        public static DB GetInstance()
        {
            if (instance == null)
                instance = new DB();
            return instance;
        }
        public DataTable RunSelect(string zapros)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(zapros, connection);
            DataTable dt = new DataTable();
            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public bool RunInsert(string command)
        {

            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (InvalidOperationException)
            {
                connection.Close();
                return false;
            }
        }

        public bool AddEntry(string[] values, string tableTitle) //false если не удалось добавить запись
        {
            string command = "insert into " + tableTitle + " values ('" + values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (i == values.Length - 1)
                    command += "','" + values[i] + "')";
                else
                    command += "','" + values[i];

            }
            return RunInsert(command);
        }
        public void RemoveEntry()
        {

        }

        public DataTable SelectEntireTable(string tableName)
        {
            SqlCommand cmd = new SqlCommand("select * from " + tableName, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        internal User Login(string login, string password) //Определяем кто это по типу
        {
            DataTable dt = RunSelect("Select * from Autorization inner join Employees on Autorization.Employee_ID = Employees.ID_Employee inner join Positions on Employees.Position_ID = Positions.ID_Position where Login = '" + login + "' and Password = '" + password + "'");
            if (dt.Rows.Count != 0)
            {
                User user = new User();
                DataRow row = dt.Rows[0];
                user.Id = (int)row["ID_Employee"];
                user.Surname = row["Surname"].ToString();
                user.Name = row["Name"].ToString();
                user.Patronymic = row["Patronymic"].ToString();
                int positionID = Convert.ToInt32(row["Position_ID"]);
                if (positionID == 3)
                    user.IsManager = false;
                else if (positionID == 4)
                    user.IsManager = true;
                return user;
            }
            return null;
        }

        //internal string AddNewEmployee(string login, string password, string surname, string name, string patronyc, DateTime birth, string passport, string email)
        //{
        //    try
        //    {
        //        RunInsert("Insert into Employees(Surname,Name,Patronymic,Birth_Date,Email,Passport_Seria,Position) Values ('" + surname + "','" + name + "','" + patronyc + "','" + birth + "','" + email + "','" + passport + "',3)");
        //        return "Ок";
        //    }
        //    catch
        //    {
        //        return "Не Ок";
        //    }
        //}

        internal bool AddNewEmployee(string login, string password, string surname, string name, string patronymic, DateTime birth, string email, string passportID, string passportGivenBy, DateTime dateGiven, string regAddress)
        {
            if (AddEntry(new string[] { surname, name, patronymic, birth.ToString("yyyy-MM-dd"), email, passportID, passportGivenBy, dateGiven.ToString("yyyy-MM-dd"), regAddress, "3" }, "Employees")) //3 это ID должности,в данном случае клиент
            {
                int newClientID = (int)RunSelect("select max(ID_Employee) from Employees").Rows[0][0];
                AddEntry(new string[] { newClientID.ToString(), login, password }, "Autorization");
                return true;
            }
            else
                return false;
        }

        internal bool CheckIfLoginExists(string login)// "ПроверитьСуществуетЛиТакойЛогин true-существует/
        {
            if (RunSelect("Select * From Autorization where Login = '" + login + "'").Rows.Count == 0)
            { return false; }
            else
            {
                return true;
            }
        }
    }
}
