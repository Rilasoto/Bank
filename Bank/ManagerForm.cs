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
            LoadRemainigHolidays(loggedUser);

        }
        public void LoadRating(User user)
        {
            DataRow dr = db.RunSelect("select Manager_Raiting from Employees where ID_Employee = " + user.Id).Rows[0];
            ratingLabel.Text = dr[0].ToString();
        }

        void LoadRemainigHolidays(User user)
        {
            DataRow dr = db.RunSelect("select Manager_HolidayDays from Employees where ID_Employee = " + user.Id).Rows[0];
            remainingHolidaysLabel.Text = dr[0].ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Close();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.GetInstance().Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientsCatalog().Show(this);
        }
    }
}
