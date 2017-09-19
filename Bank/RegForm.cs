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

        private void button2_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        public RegForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Не все данные заполнены!","Ошибка");
            }
            if (textBox1.Text == "") { label1.ForeColor = Color.Red; }
            if (textBox2.Text == "") { label2.ForeColor = Color.Red; }
            if (textBox3.Text == "") { label3.ForeColor = Color.Red; }
            if (textBox6.Text == "") { label5.ForeColor = Color.Red; }
            if (maskedTextBox1.Text == "") { label6.ForeColor = Color.Red; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string pattern = "\\w*@\\w\\.\\w*";
            if (!Regex.IsMatch(textBox6.Text, pattern))
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                DateTime date1 = DateTime.Now;     
                second += 0.103;
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
