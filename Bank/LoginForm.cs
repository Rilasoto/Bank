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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBox1.GotFocus += ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yfdfd");
        }

        private void PlaceHolderFocused()
        {

        }
        private void PlaceHolderLostFocus()
        { }
    }
}
