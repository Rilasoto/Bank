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
    public partial class ClientForm : Form
    {
        User user;
        int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;

        public ClientForm(User user)
        {
            this.user = user;
            InitializeComponent();
            surnameLabel.Text = user.Surname;
            nameLabel.Text = user.Name;
            patronymicLabel.Text = user.Patronymic;
            LoadLastTransactions();
           
            timer1.Start();
        }

        public void LoadLastTransactions()
        {
            dataGridView1.DataSource = DB.GetInstance().RunSelect(@"select ID_Payment as [Номер платежа] ,DateOfPayment as [Дата платежа], ServiceName as [Услуга], Sum as Сумма
                                                                        from Payments left join Accounts on Payments.Account_ID = Accounts.ID_Account
                                                                                      left join Service on Service_ID = ID_Service 
                                                                                      left join Credits on Payments.Credit_ID = Credits.ID_Credit
                                                                                      where Accounts.Employee_ID = " + user.Id + @"
                                                                                            OR Credits.Employee_ID = " + user.Id + " order by DateOfPayment");

            DebetDataGrid.DataSource = DB.GetInstance().RunSelect(@"Select Numbers as Счет,SummDebit as [Сумма на балансе]
                                                                    From Accounts where Employee_ID ='" + this.user.Id + "' ");
            CreditDataGrid.DataSource = DB.GetInstance().RunSelect(@"Select StartDate as [Дата кредитования],TotalSumm as [Задолжность], MonthlySumm as [Месячный платеж]
                                                                    From Credits where Employee_ID ='" + this.user.Id + "' ");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo))
            {
                this.Close();
                LoginForm.GetInstance().Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionForm.GetInstance(user).Show(this);
            TransactionForm.GetInstance(user).Focus();
        }

        private void курсыВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExchangeRates().Show();
        }

        private void информацияОБанкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoAboutBank().Show();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.GetInstance().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            second += 0.103;
            if (second >= 60)
            {
                second = 0;
                minute += 1;
            }
            if (minute >= 60)
            {
                minute = 0;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour = 0;
                day += 1;
            }
            if (typedate)
            {
                label10.Text = day.ToString() + " дней " + hour.ToString() + " часов " + minute.ToString() + " минут " + Math.Round(second, 0).ToString() + " секунд";
            }
            else
            {
                label10.Text = date1.ToString();
            }
        }
    }
}
