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
           
            this.user = user;
            InitializeComponent();
            InitServicesComboBox();
            InitCreditComboBox();
            db = DB.GetInstance();
            InitAccountsComboBox();
            UpdateDataGrid();
        }
        void UpdateDataGrid()
        {
            dataGridView1.DataSource = db.RunSelect(@"select ID_Payment as [Номер платежа] ,DateOfPayment as [Дата платежа], ServiceName as [Услуга], Sum as Сумма
                                                                        from Payments left join Accounts on Payments.Account_ID = Accounts.ID_Account
                                                                                      left join Service on Service_ID = ID_Service 
                                                                                      left join Credits on Payments.Credit_ID = Credits.ID_Credit
                                                                                      where Accounts.Employee_ID = " + user.Id + @"
                                                                                            OR Credits.Employee_ID = " + user.Id + " order by DateOfPayment");
            //dataGridView1.Columns[0].ValueType = typeof(String);

            //foreach (DataGridViewColumn dc in dataGridView1.Columns)
            //    dc.Visible = false;
            //string[] valuesToShow = new string[] { "Account_ID", "ServiceName", "Sum" };    /// От это вообще пиздец ЕГОР       (凸ಠ益ಠ)凸 ٩(╬ʘ益ʘ╬)۶ ٩(ఠ益ఠ)۶
            //string[] translaTions = new string[] { "Счет", "Услуга", "Сумма" };             // Просто ДЦЕПЕ-STYLO . . . .. . .   	(凸ಠ益ಠ)凸      (ﾉಥ益ಥ)ﾉ
            //for (int i = 0; i < valuesToShow.Length; i++)
            //{
            //    dataGridView1.Columns[valuesToShow[i]].Visible = true;
            //    dataGridView1.Columns[valuesToShow[i]].HeaderText = translaTions[i];
            //}
        }

        void InitServicesComboBox()
        {
            DataTable dt = DB.GetInstance().RunSelect("select ServiceName from Service");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                servicesComboBox.Items.Add(dt.Rows[i][0]);
            }

            //servicesComboBox.DataSource = DB.GetInstance().SelectEntireTable("Service");
            //servicesComboBox.DisplayMember = "ServiceName";
            //servicesComboBox.ValueMember = "ID_Service";
            //servicesComboBox.SelectedIndex = -1;
        }
        void InitCreditComboBox()
        {
            DataTable dt = DB.GetInstance().RunSelect("select ID_Credit from Credits where Employee_ID = '"+user.Id+"'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                creditsComboBox.Items.Add(dt.Rows[i][0]);
            }

            //servicesComboBox.DataSource = DB.GetInstance().SelectEntireTable("Service");
            //servicesComboBox.DisplayMember = "ServiceName";
            //servicesComboBox.ValueMember = "ID_Service";
            //servicesComboBox.SelectedIndex = -1;
        }

        void InitAccountsComboBox()
        {
           DataTable dt = DB.GetInstance().RunSelect("select Numbers from accounts where Employee_ID =" + user.Id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                accountsComboBox.Items.Add(dt.Rows[i][0]);
            }
            //accountsComboBox.DataSource = db.RunSelect("select * from accounts where Employee_ID =" + user.Id);
            //accountsComboBox.ValueMember = "ID_Account";
            //accountsComboBox.DisplayMember = "Numbers";
            //accountsComboBox.SelectedIndex = -1;
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
            double currentmoney = 0;
            if (servicesComboBox.SelectedIndex == -1 || accountsComboBox.SelectedItem == null || sumTextBox.Text == "")
                MessageBox.Show("Не все поля заполнены");
            else
            {
                int IDService =Convert.ToInt32(db.RunSelect("Select ID_Service from Service where ServiceName = '"+ servicesComboBox.SelectedItem.ToString() + "'").Rows[0][0]);

                if (servicesComboBox.SelectedItem.ToString() == "Плата по кредиту") // Плата по кредиту 
                {
                    currentmoney = Convert.ToDouble(db.RunSelect(@"Select SummDebit
                                                                        from Accounts 
                                                                         where Employee_ID = '" + user.Id + "' ").Rows[0][0]); // текущий баланс дебетового счета

                    if (creditsComboBox.SelectedItem.ToString() != "")
                    {
                        if (currentmoney >= Convert.ToDouble(sumTextBox.Text))
                        {
                            db.RunInsert("Insert into Payments(Service_ID,Credit_ID,Sum,DateOfPayment) values('" + IDService + "','" + creditsComboBox.SelectedItem.ToString() + "','" + sumTextBox.Text + "','" + DateTime.Now + "')");
                            //Уменьшение размера долга на сумму вноса
                            db.RunInsert(@"update Credits set  TotalSumm = TotalSumm - '" + sumTextBox.Text + @"'
                                       where ID_Credit = '" + creditsComboBox.Text + "';");

                            // Снятие денег с дебетового счета
                            db.RunInsert(@"update Accounts set SummDebit = SummDebit - '" + sumTextBox.Text + @"'
                                       where Employee_ID = '" + user.Id + "';");
                            (this.Owner as ClientForm).LoadLastTransactions();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("На указанном счету не хватает средств!");
                        }
                    }
                    else { MessageBox.Show("Не все поля заполнены"); }
                }

                else                                                // Плата по услуге
                {                                                             
                    int IDAccount = Convert.ToInt32(db.RunSelect(@"Select Accounts.ID_account 
                                                                from Accounts left join Employees on Accounts.Employee_ID = Employees.ID_Employee
                                                                where Accounts.Employee_ID = '" +user.Id + "'").Rows[0][0]);
                    db.RunInsert("Insert into Payments(Service_ID,Account_ID,Sum,DateOfPayment) values('" + IDService + "','" + IDAccount + "','" + sumTextBox.Text + "','" + DateTime.Now + "')");

                    db.RunInsert(@"update Accounts set SummDebit = SummDebit - '" + sumTextBox.Text + @"' 
                                       where Employee_ID = '" + user.Id + "';"); //  снятие средств с дебетового счета
                    (this.Owner as ClientForm).LoadLastTransactions();
                    this.Close();
                }

                //if (db.AddEntry(new string[] { servicesComboBox.SelectedValue.ToString(), accountsComboBox.SelectedItem.ToString(), sumTextBox.Text }, "Payments"))
                //{
                //    groupBox1.Visible = false;
                //    dataGridView1.Visible = true;

                //    UpdateDataGrid();
                //    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                //}
                //else
                //    MessageBox.Show("Ошибка");

                
                
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

        private void servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicesComboBox.SelectedItem != null)
            {
                if (servicesComboBox.SelectedItem.ToString() == "Плата по кредиту")
                    groupBox1.Size = new Size(330, 209);
                else
                    groupBox1.Size = new Size(190, 209);
            }
        }

        private void creditsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (creditsComboBox.SelectedItem != null && creditsComboBox.SelectedItem.ToString() != "")
            {
                DataTable dt = db.RunSelect(@"Select StartDate , TotalSumm 
                                                       from Credits 
                                                       WHERE ID_Credit = '"+ creditsComboBox.SelectedItem.ToString() + "'");
                dateCredit.Text = dt.Rows[0][0].ToString();
                    creditlastsumm.Text = dt.Rows[0][1].ToString();
            }
        }
    }
}
