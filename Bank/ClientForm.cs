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
    public partial class ClientForm : Form
    {
        int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        public ClientForm(Object c)
        {
            Client b = (Client)c; 
            InitializeComponent();
            surnameLabel.Text = b.Surname;
            nameLabel.Text = b.Name;
            patronymicLabel.Text = b.Patronymic;

            timer1.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
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
                label10.Text = day.ToString() + " дней " + hour.ToString() + " часов " + minute.ToString() + " минут " + Math.Round(second, 0).ToString() + " секунд";
            }
            else
            {
                label10.Text = date1.ToString();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
