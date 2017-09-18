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
        Controller c;

        public LoginForm()
        {
            InitializeComponent();

            c = Controller.GetInstance();
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

        private void textBox_Enter(object sender, EventArgs e)
        {
            if(!text1Changed)
            {
                textBox1.Text = "";
            }
        }
    }
}
