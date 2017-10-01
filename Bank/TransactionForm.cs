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
    public partial class TransactionForm : Form
    {
        static TransactionForm instance;
        public static TransactionForm GetInstance()
        {
            if (instance == null)
                instance = new TransactionForm();
            return instance;
        }

        public TransactionForm()
        {
            InitializeComponent();
            InitServicesComboBox();
        }
        void InitServicesComboBox()
        {
            servicesComboBox.DataSource = DB.GetInstance().SelectEntireTable("Service");
            servicesComboBox.DisplayMember = "ServiceName";
            servicesComboBox.ValueMember = "ID_Service";
            servicesComboBox.SelectedIndex = -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           instance = null;
        }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
