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
using System.Text.RegularExpressions;
using DBAdapter;

namespace GUI
{
    public partial class RegForm : Form
    {
        public int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        DB db;

        public RegForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 2000;
            db = DB.GetInstance();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportBox.Text == "" || errorPassPic.Visible == true || loginErrorPic.Visible == true || erroremail.Visible == true)
            {
                MessageBox.Show("Не все данные заполнены верно!", "Ошибка");
            }
            else
            {
                if (db.AddNewEmployee(loginBox.Text, passwordBox.Text, surnameBox.Text, nameBox.Text, patronymicBox.Text, dateBirth.Value, emailBox.Text, passportBox.Text, richGivenBy.Text, dateGiven.Value, textRegAddress.Text))
                {
                    MessageBox.Show("Регистрация прошла успешно");
                    this.Close();
                    if (Owner is ClientsCatalog)
                    {
                        (Owner as ClientsCatalog).InitializeDatagrid();
                        (Owner as ClientsCatalog).SelectLastRow();
                    }
                    else
                    {
                        LoginForm.GetInstance().Show();
                    }
                }

                else
                    MessageBox.Show("Ошибка");
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
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

        private void textBoxPassword2_TextChanged(object sender, EventArgs e)
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

        private void RegForm_Load(object sender, EventArgs e)
        {


        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void RegForm_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
                if (Owner is ClientsCatalog)
                    (Owner as ClientsCatalog).EnterViewMode();
                else
                    LoginForm.GetInstance().Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (db.CheckIfLoginExists(loginBox.Text))
                    loginErrorPic.Visible = true;
                else
                    loginErrorPic.Visible = false;
                timer2.Stop();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            second += 1;
            if (second >= 60)
            {
                second = 0;
                minute += 1;
            }
            if (minute >= 60)
            {
                minute = 0;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour = 0;
                day += 1;
            }
            if (typedate)
            {
                labelTime.Text = day.ToString() + " дней " + hour.ToString() + " часов " + minute.ToString() + " минут " + Math.Round(second, 0).ToString() + " секунд";
            }
            else
            {
                labelTime.Text = date1.ToString();
            }
        }

    }
}
