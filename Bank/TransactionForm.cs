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
    public partial class TransactionForm : Form
    {
        static TransactionForm instance;
        DB db;
        User user;
        public static TransactionForm GetInstance(User user)
        {
            if (instance == null)
                instance = new TransactionForm(user);
            return instance;
        }

        public TransactionForm(User user)
        {
            InitializeComponent();
            InitServicesComboBox();
            this.user = user;
            db = DB.GetInstance();
            InitAccountsComboBox();
            UpdateDataGrid();
        }
        void UpdateDataGrid()
        {
            dataGridView1.DataSource = db.RunSelect("Select * from Payments join Accounts on ID_account = Payments.Account_ID join Service on ID_Service=Service_ID where Accounts.Employee_ID =" + user.Id);
            dataGridView1.Columns[0].ValueType = typeof(String);

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
                dc.Visible = false;
            string[] valuesToShow = new string[] { "Account_ID", "ServiceName", "Sum" };
            string[] translaTions = new string[] { "Счет", "Услуга", "Сумма" };
            for (int i = 0; i < valuesToShow.Length; i++)
            {
                dataGridView1.Columns[valuesToShow[i]].Visible = true;
                dataGridView1.Columns[valuesToShow[i]].HeaderText = translaTions[i];
            }
        }

        void InitServicesComboBox()
        {
            servicesComboBox.DataSource = DB.GetInstance().SelectEntireTable("Service");
            servicesComboBox.DisplayMember = "ServiceName";
            servicesComboBox.ValueMember = "ID_Service";
            servicesComboBox.SelectedIndex = -1;
        }

        void InitAccountsComboBox()
        {
            DataTable dt = db.RunSelect("select ID_account from accounts where Employee_ID =" + user.Id);
            foreach (object s in dt.Rows[0].ItemArray)
            {
                accountsComboBox.Items.Add(AddZeros(Convert.ToString(s)));
            }
            accountsComboBox.ValueMember = "ID_Account";
            accountsComboBox.DisplayMember = "ID_Account";
            accountsComboBox.SelectedIndex = -1;
        }

        string AddZeros(string s)//Для нормального отображения счета
        {
            string output = "";
            for (int i = 0; i < 16 - s.Length; i++)
            {
                output += "0";
            }
            return output + s;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            addButton.Enabled = false;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (servicesComboBox.SelectedIndex == -1 || accountsComboBox.SelectedItem == null || sumTextBox.Text == "")
                MessageBox.Show("Не все поля заполнены");
            else
            {
                if (db.AddEntry(new string[] { servicesComboBox.SelectedValue.ToString(), accountsComboBox.SelectedItem.ToString(), sumTextBox.Text }, "Payments"))
                {
                    groupBox1.Visible = false;
                    dataGridView1.Visible = true;

                    UpdateDataGrid();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                }
                else
                    MessageBox.Show("Ошибка");

                (this.Owner as ClientForm).LoadLastTransactions();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ExitAddMode();
        }

        void ExitAddMode()
        {
            servicesComboBox.SelectedIndex = -1;
            sumTextBox.Text = "";
            accountsComboBox.SelectedIndex = -1;
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
            addButton.Enabled = true;
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
