using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InteractiveMap : Form
    {
        public InteractiveMap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InteractiveMap_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo))
            {
                LoginForm.GetInstance().Close();
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Orange;
            label3.BackColor = Color.Orange;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;
            label7.BackColor = Color.WhiteSmoke;
            label8.BackColor = Color.WhiteSmoke;
            label9.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.Orange;
            label5.BackColor = Color.Orange;
            label6.BackColor = Color.WhiteSmoke;
            label7.BackColor = Color.WhiteSmoke;
            label8.BackColor = Color.WhiteSmoke;
            label9.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.Orange;
            label7.BackColor = Color.Orange;
            label8.BackColor = Color.WhiteSmoke;
            label9.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;
            label7.BackColor = Color.WhiteSmoke;
            label8.BackColor = Color.Orange;
            label9.BackColor = Color.Orange;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;
            label7.BackColor = Color.WhiteSmoke;
            label8.BackColor = Color.WhiteSmoke;
            label9.BackColor = Color.WhiteSmoke;
        }
    }
}
