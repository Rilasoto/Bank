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
            if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportBox.Text == "")
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка");
            }
            if (surnameBox.Text == "") { label1.ForeColor = Color.Red; }
            if (nameBox.Text == "") { label2.ForeColor = Color.Red; }
            if (patronymicBox.Text == "") { label3.ForeColor = Color.Red; }
            if (emailBox.Text == "") { label5.ForeColor = Color.Red; }
            if (passportBox.Text == "") { label6.ForeColor = Color.Red; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string pattern = "\\w*@\\w\\.\\w*";
            if (!Regex.IsMatch(emailBox.Text, pattern))
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (controller.CheckIfLoginExists(loginBox.Text))
                    loginErrorPic.Visible = false;
                else
                    loginErrorPic.Visible = true;
                MessageBox.Show("Update");
            }
            timer2.Stop();
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
                label8.Text = day.ToString() + " дней " + hour.ToString() + " часов " + minute.ToString() + " минут " + Math.Round(second, 0).ToString() + " секунд";
            }
            else
            {
                label8.Text = date1.ToString();
            }
        }

    }
}
