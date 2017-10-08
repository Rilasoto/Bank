using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAdapter;

namespace GUI
{
    public partial class ClientsCatalog : Form
    {
        DB db;
        public ClientsCatalog()
        {
            InitializeComponent();
            db = DB.GetInstance();
            InitializeDatagrid();
        }
        public void SelectRowWithID(string id)
        {

        }
        public void SelectLastRow()
        {
            if (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
        }
        public void InitializeDatagrid()
        {
            dataGridView1.DataSource = db.RunSelect("Select * from Employees where Position_ID = 3");
            dataGridView1.Columns[0].ValueType = typeof(String);

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
                dc.Visible = false;
            string[] valuesToShow = new string[] { "Surname", "Name", "Patronymic", "Birth_Date", "Email", "Passport_Seria", "Passport_GivenBy", "Passport_RegistrationAddress" };
            string[] translaTions = new string[] { "Фамилия", "Имя", "Отчество", "Дата рождения", "e-mail", "Серия номер паспорта", "Кем выдан", "Когда выдан", "Адрес регистрации" };
            for (int i = 0; i < valuesToShow.Length; i++)
            {
                dataGridView1.Columns[valuesToShow[i]].Visible = true;
                dataGridView1.Columns[valuesToShow[i]].HeaderText = translaTions[i];
            }
        }
        public void EnterViewMode()
        {
            this.Enabled = true;
        }
        public void EnterEditMode()
        {
            this.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new RegForm().Show(this);
            EnterEditMode();
        }
    }
}
