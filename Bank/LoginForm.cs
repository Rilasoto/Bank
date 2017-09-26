using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logics;

namespace GUI
{
    public partial class LoginForm : Form
    {
        bool text1Changed = false, text2Changed = false;
        int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        Controller c;

        public LoginForm()
        {
            InitializeComponent();
            c = Controller.GetInstance();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!text2Changed)
            {
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c.OpenRegForm();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Login(textBox1.Text, textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if(!text1Changed)
            {
                textBox1.Text = "";
            }
        }
    }
}
