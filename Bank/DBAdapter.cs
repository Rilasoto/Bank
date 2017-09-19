using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics;
using System.Data.SqlClient;
using System.Data;

namespace DBAdapter
{
    class DBAdapter
    {
        Controller controller;
        string connectionString = "Data Source=DESKTOP-V4KR3NR;Initial Catalog=ProjectBank;Integrated Security=True";

        static DBAdapter instance;
        public static DBAdapter GetInstance()
        {
            if (instance == null)
                instance = new DBAdapter();
            return instance;
        }
        public DataTable RunSelect(string zapros)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(zapros, connection);
            DataTable dt = new DataTable();
            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public string RunInsert(string zapros)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = zapros;
            cmd.ExecuteNonQuery();
            cmd.Clone();
            connection.Close();
            return "Ок";
        }

        internal User Login(string login, string password) //Определяем кто это по типу
        {
            DataTable dt = RunSelect("Select Employees.Surname as Фамилия,Employees.Name as Имя,Employees.Patronymic as Отчество, Positions.Position_Name as Должность, Employees.Birth_Date as ДатаРождения   From (Autorization inner join Employees on Autorization.ID_Employee = Employees.ID_Employee) inner join Positions on Employees.Position = Positions.ID_Position where Login = '" + login+ "' and Password = '" + password+"'");
            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0][3].ToString() == "Клиент")
                {
                    Client newClient = new Client(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    return newClient;
                }
                //if (dt.Rows[0][3].ToString() == "Менеджер") // Менеджер
                //{

                //}
            }
            //Создавать объекты клиентов или манагеров будет адаптер, в базе можно какую-нибудь булевскую переменную (манагер/не манагер)
            return null;
        }

        internal string AddNewEmployee(string login, string password, string surname, string name, string patronyc, DateTime birth, string passport, string email)
        {
            try
            {
                RunInsert("Insert into Employees(Surname,Name,Patronymic,Birth_Date,Email,Passport_Seria,Position) Values ('" + surname + "','" + name + "','" + patronyc + "','" + birth + "','" + email + "','" + passport + "',3)");
                return "Ок";
            }
            catch
            {
                return "Не Ок";
            }
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
