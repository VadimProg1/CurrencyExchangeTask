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
        Model model = new Model();
        Random rnd = new Random();
        bool isPaused = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !isPaused)
            {
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas[0].AxisX.Maximum = (double)numeric_days.Value;
                chart1.Series[0].Points.AddXY(0, numeric_initial_price.Value);

                model.Setup((int)numeric_initial_price.Value,
                    (int)numeric_days.Value,
                    (int)numericStartCapital.Value);

                UpdateLabels();
                InterfaceWorkPosition();
                timer1.Interval = (int)numeric_dayLength.Value * 1000;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(model.WallStreetIsOpened())
            {
                model.TypicalWallStreetDay(rnd.NextDouble());
                UpdateLabels();
                chart1.Series[0].Points.AddXY(model.daysPassed, model.price);
            }
            else
            {
                InterfaceStartPosition();
                timer1.Stop();
            }
        }

        private void InterfaceStartPosition()
        {
            numeric_days.Enabled = true;
            numericStartCapital.Enabled = true;
            numeric_initial_price.Enabled = true;
        }

        private void InterfaceWorkPosition()
        {
            numeric_days.Enabled = false;
            numericStartCapital.Enabled = false;
            numeric_initial_price.Enabled = false;
        }

        private void UpdateLabels()
        {
            day_label.Text = (model.daysPassed).ToString();
            walletLabel.Text = model.GetWalletMoney().ToString() + " rub";
            brokerageLabel.Text = model.GetInvestedMoney().ToString() + " rub";
        }

        private void invest_button_Click(object sender, EventArgs e)
        {
            model.InvestMoney((int)numeric_sellAndInvest.Value);
            UpdateLabels();
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            model.SellMoney((int)numeric_sellAndInvest.Value);
            UpdateLabels();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numeric_dayLength.Value * 1000;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                isPaused = true;
                pause_button.Text = "Unpause";
                timer1.Stop();
            }
            else
            {
                isPaused = false;
                pause_button.Text = "Pause";
                timer1.Start();
            }
        }
    }
}
