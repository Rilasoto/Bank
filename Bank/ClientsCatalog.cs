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
using System.IO;


namespace GUI
{ 
    public partial class ClientsCatalog : Form
    { 
        DB db;
        bool isEdit;

        public bool IsEdit
        {
            set { isEdit = value; }
            get { return isEdit; }
            
        }
        public ClientsCatalog()
        {
            InitializeComponent();
            db = DB.GetInstance();
            InitializeDatagrid();
        }
        public void SelectRowWithID(int id)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (Convert.ToInt32(dr.Cells["ID_Employee"].Value) == id)
                {
                    dr.Selected = true;
                }
            }

        }
        public void SelectLastRow()
        {
            if (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
        }
        public void InitializeDatagrid()
        {
            dataGridView1.DataSource = db.RunSelect("Select * from Employees join Autorization  on Employee_ID=ID_Employee where Position_ID = 3");
            dataGridView1.Columns[0].ValueType = typeof(String);

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
                dc.Visible = false;

            string[] valuesToShow = new string[] { "Surname", "Name", "Patronymic", "Login", "Password", "Birth_Date", "Email", "Passport_Seria", "Passport_GivenBy", "Passport_RegistrationAddress" };
            string[] translaTions = new string[] { "Фамилия", "Имя", "Отчество", "Логин", "Пароль", "Дата рождения", "e-mail", "Серия номер паспорта", "Кем выдан", "Когда выдан", "Адрес регистрации" };

            for (int i = 0; i < valuesToShow.Length; i++)
            {
                dataGridView1.Columns[valuesToShow[i]].Visible = true;
                dataGridView1.Columns[valuesToShow[i]].HeaderText = translaTions[i];
            }
        }
        public void UpdateTable()
        {
            dataGridView1.DataSource = db.RunSelect("Select * from Employees join Autorization  on Employee_ID=ID_Employee where Position_ID = 3");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.isEdit = false;
            RegForm reg = new RegForm();
            reg.Show(this);
        }
        

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.Enabled = false;

                RegForm reg = new RegForm();
                reg.IsEditMode = true;
                reg.UserID = (int)dataGridView1.SelectedRows[0].Cells["ID_Employee"].Value;
                reg.FillFieldsWithData(dataGridView1.SelectedRows[0]);
                reg.Show(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            DateTime today = DateTime.Now;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                //    FBD.SelectedPath

                StringBuilder sb = new StringBuilder(); 

                foreach (DataGridViewRow dr in dataGridView1.Rows) // доделать запись всех показанных клиентов в cvs-файл
                {
                    
                    DataTable dt = db.RunSelect(@"Select Surname,Name,Patronymic,Birth_Date,Email,Passport_Seria,Passport_Givenby,Passport_Givenwhen,Passport_RegistrationAddress,Position_Name
                                                    from Employees inner join Positions on Employees.Position_ID =  Positions.ID_Position
                                                    where ID_Employee ='" + dr.Cells[0].Value.ToString() + "'");
                    DateTime dateBirth = Convert.ToDateTime(dt.Rows[0][3]);
                    DateTime whengiven = Convert.ToDateTime(dt.Rows[0][7]);
                    sb.AppendLine(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1] + " " + dt.Rows[0][2] + "," + dateBirth.ToString("D").Substring(0, dateBirth.ToString("D").Length - 1) + "," + ((today - dateBirth).Days / 365).ToString() + "," + dt.Rows[0][4] + "," + dt.Rows[0][5] + "," + dt.Rows[0][6] + "," + whengiven.ToString("D").Substring(0, whengiven.ToString("D").Length - 1) + "," + dt.Rows[0][8]);
                }

                using (StreamWriter sw = new StreamWriter(FBD.SelectedPath + "\\Клиенты "+ today.ToString("D").Substring(0, today.ToString("D").Length - 1) + ".cvs"))
                {
                    sw.Write(sb.ToString()); 
                }

            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
                dataGridView1.CurrentCell = null;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(textBox1.Text.ToLower()))
                {
                    row.Visible = true;
                    continue;
                }
                else
                    if (row.Cells[2].Value.ToString().Contains(textBox1.Text.ToLower()))
                {
                    row.Visible = true;
                    continue;
                }
                else if (row.Cells[3].Value.ToString().Contains(textBox1.Text.ToLower()))
                {
                    row.Visible = true;
                    continue;
                }
                row.Visible = false;
            }
        }

        private void buttonEmaaail_Click(object sender, EventArgs e)
        {
            new EmailList().Show(this);
        }
    }
}
