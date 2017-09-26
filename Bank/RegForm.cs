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

namespace GUI
{
    public partial class RegForm : Form
    {
        public int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;

        Controller controller;

        private void button2_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        public RegForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 2000;
            controller = Controller.GetInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportBox.Text == "" || errorPassPic.Visible == true || loginErrorPic.Visible == true || erroremail.Visible == true)
            {
                MessageBox.Show("Не все данные заполнены верно!", "Ошибка");
            }
            else
            {
                controller.addman(loginBox.Text,passwordBox.Text,surnameBox.Text,nameBox.Text,patronymicBox.Text,dateTimePicker1.Value,passportBox.Text,emailBox.Text);
                this.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

        private void password2Box_TextChanged(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (controller.CheckIfLoginExists(loginBox.Text))
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
