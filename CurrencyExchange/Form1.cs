using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        const double k = 0.02;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double price = (double)numeric_initial_price.Value;
            int days = (int)numeric_days.Value;
            chart1.Series[0].Points.AddXY(0, price);
            for (int i = 1; i <= days; i++)
            {
                price = price * (1 + k * (rnd.NextDouble() - 0.5));
                chart1.Series[0].Points.AddXY(i, price);
            }
        }
    }
}
