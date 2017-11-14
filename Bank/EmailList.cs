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
    public partial class EmailList : Form
    {
        DBAdapter.DB db;
        string output = "";
        public EmailList()
        {
            InitializeComponent();
            db = DBAdapter.DB.GetInstance();
            ShowEmails();
        }
       public void ShowEmails()
        {
            DataTable dt = db.RunSelect("select Surname,Name,Patronymic,email from Employees");
            
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                output += dr["Surname"].ToString() + " " +
                    dr["Name"].ToString() + " " +
                    dr["Patronymic"].ToString() + " " +
                    dr["Email"].ToString();
                if (i != dt.Rows.Count - 1)
                    output += ", ";
                i++;
            }
            richTextBox1.Text = output;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(output);
        }

        private void EmailList_Load(object sender, EventArgs e)
        {

        }
    }
}
