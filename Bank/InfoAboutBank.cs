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
    public partial class InfoAboutBank : Form
    {
        public InfoAboutBank()
        {
            InitializeComponent();
        }

        private void InfoAboutBank_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo))
            {

                LoginForm.GetInstance().Close();
            }
        }
    }
}
