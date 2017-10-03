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
    public partial class ExchangeRates : Form
    {
        public ExchangeRates()
        {
            InitializeComponent();
            DataTable dollardt = DB.GetInstance().RunSelect("select TOP 1 Exchange_rates_out,Exchange_rates_in From ExchangeRates  where Date <='" + dateTimePicker1.Value + "' and ID_Currency1 = 1 ORDER BY Date DESC");
            DataTable eurodt = DB.GetInstance().RunSelect("select TOP 1 Exchange_rates_out,Exchange_rates_in From ExchangeRates where Date <='" + dateTimePicker1.Value + "' and ID_Currency1 = 2 ORDER BY Date DESC");
            DollarBuy.Text = dollardt.Rows[0][0].ToString();
            DollarSell.Text = dollardt.Rows[0][1].ToString();
            EuroBuy.Text = eurodt.Rows[0][0].ToString();
            EuroSell.Text = eurodt.Rows[0][1].ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataTable dollardt = DB.GetInstance().RunSelect("select TOP 1 Exchange_rates_out,Exchange_rates_in From ExchangeRates  where Date <='" + dateTimePicker1.Value + "' and ID_Currency1 = 1 ORDER BY Date DESC");
            DataTable eurodt = DB.GetInstance().RunSelect("select TOP 1 Exchange_rates_out,Exchange_rates_in From ExchangeRates where Date <='" + dateTimePicker1.Value + "' and ID_Currency1 = 2 ORDER BY Date DESC");
            DollarBuy.Text = dollardt.Rows[0][0].ToString();
            DollarSell.Text = dollardt.Rows[0][1].ToString();
            EuroBuy.Text = eurodt.Rows[0][0].ToString();
            EuroSell.Text = eurodt.Rows[0][1].ToString();
        }
    }
}
