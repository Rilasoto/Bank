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
using DBAdapter;

namespace GUI
{
    public partial class LoginForm : Form
    {
        static LoginForm instance;
        bool text1Changed = false, text2Changed = false;
        int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        DB db;

        public LoginForm()
        {
            InitializeComponent();
            db = DB.GetInstance();
            timer1.Interval = 1000;
            timer1.Start();
        }

        public static LoginForm GetInstance()
        {
            if (instance == null)
                instance = new LoginForm();
            return instance;
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (!text2Changed)
            {
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm.GetInstance().Hide();
            new RegForm().Show(this);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            User loggedUser = db.Login(textBox1.Text, textBox2.Text);
            if (loggedUser != null)
                if (loggedUser.IsManager)
                {
                    new ManagerForm(loggedUser).Show();
                    this.Hide();
                }
                else
                {
                    new ClientForm(loggedUser).Show();
                    this.Hide();

                }
            else
                MessageBox.Show("Неверный логин/пароль");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton_Click(this, null);
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (!text1Changed)
            {
                textBox1.Text = "";
            }
        }
    }
}
