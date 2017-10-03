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
    public partial class ManagerForm : Form
    {
        DB db = DBAdapter.DB.GetInstance();
        public ManagerForm(User loggedUser)
        {
            InitializeComponent();
            surnameLabel.Text = loggedUser.Surname;
            nameLabel.Text = loggedUser.Name;
            patronymicLabel.Text = loggedUser.Patronymic;
            LoadRating(loggedUser);

        }
        public void LoadRating(User user)
        {
            DataTable dt = db.RunSelect("select Manager_DateOfWork,Manager_Raiting,Manager_HolidayDays from Employees where ID_Employee = " + user.Id);
            rating.Text = dt.Rows[0][1].ToString();
            holidays.Text = dt.Rows[0][2].ToString();
           
            TimeSpan span = ((DateTime.Today - Convert.ToDateTime(dt.Rows[0][0])));
            expa.Text = (span.Days / 365).ToString();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void информацияОБанкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoAboutBank().Show();
        }
    }
}
