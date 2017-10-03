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
            DataRow dr = db.RunSelect("select Rating from EmployeeRating where Employee_ID = " + user.Id).Rows[0];
            ratingLabel.Text = dr[0].ToString();
        }
    }
}
