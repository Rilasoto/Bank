using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Logics;
using DBAdapter;

namespace GUI
{
    public partial class ChangeClientInformtion : Form
    {
        public int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        DB db;
        public ChangeClientInformtion()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 2000;
            db = DB.GetInstance();
        }

        private void ChangeClientInformtion_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // это скопированный код из формы регистрации, с кнопки регистрации. подходит ли он для вненсения измнений в существующую записьв бд?
            //if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportBox.Text == "" || errorPassPic.Visible == true || loginErrorPic.Visible == true || erroremail.Visible == true)
            //{
            //    MessageBox.Show("Не все данные заполнены верно!", "Ошибка");
            //}
            //else
            //{
            //    if (db.AddNewEmployee(loginBox.Text, passwordBox.Text, surnameBox.Text, nameBox.Text, patronymicBox.Text, dateBirth.Value, emailBox.Text, passportBox.Text, richGivenBy.Text, dateGiven.Value, textRegAddress.Text))
            //    {
            //        MessageBox.Show("Изменение данных прошло успешно");
            //        this.Close();
            //        if (Owner is ClientsCatalog)
            //        {
            //            (Owner as ClientsCatalog).InitializeDatagrid();
            //            (Owner as ClientsCatalog).SelectLastRow();
            //        }
            //        else
            //        {
            //            LoginForm.GetInstance().Show();
            //        }
            //    }

            //    else
            //        MessageBox.Show("Ошибка");
            //}
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text != password2Box.Text)
            {
                errorPassPic.Visible = true;
            }
            else
            {
                errorPassPic.Visible = false;
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "\\w+@\\w+\\.\\w+";
            if (!Regex.IsMatch(emailBox.Text, pattern))
            {
                erroremail.Visible = true;
            }
            else
            {
                erroremail.Visible = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }
    }
}
