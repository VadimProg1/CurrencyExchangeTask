
namespace CurrencyExchange
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_initial_price = new System.Windows.Forms.NumericUpDown();
            this.numeric_days = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.walet = new System.Windows.Forms.Label();
            this.walletLabel = new System.Windows.Forms.Label();
            this.numeric_sellAndInvest = new System.Windows.Forms.NumericUpDown();
            this.brokerageLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericStartCapital = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.invest_button = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_dayLength = new System.Windows.Forms.NumericUpDown();
            this.pause_button = new System.Windows.Forms.Button();
            this.day_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_initial_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_sellAndInvest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dayLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(234, 43);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Teal;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Series";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(776, 359);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(142, 191);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 28);
            this.button_calculate.TabIndex = 1;
            this.button_calculate.Text = "Start";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial price:";
            // 
            // numeric_initial_price
            // 
            this.numeric_initial_price.Location = new System.Drawing.Point(97, 43);
            this.numeric_initial_price.Name = "numeric_initial_price";
            this.numeric_initial_price.Size = new System.Drawing.Size(120, 22);
            this.numeric_initial_price.TabIndex = 3;
            this.numeric_initial_price.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numeric_days
            // 
            this.numeric_days.Location = new System.Drawing.Point(97, 76);
            this.numeric_days.Name = "numeric_days";
            this.numeric_days.Size = new System.Drawing.Size(120, 22);
            this.numeric_days.TabIndex = 5;
            this.numeric_days.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Days:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // walet
            // 
            this.walet.AutoSize = true;
            this.walet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walet.Location = new System.Drawing.Point(39, 351);
            this.walet.Name = "walet";
            this.walet.Size = new System.Drawing.Size(80, 25);
            this.walet.TabIndex = 6;
            this.walet.Text = "Wallet:";
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletLabel.Location = new System.Drawing.Point(113, 351);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(61, 25);
            this.walletLabel.TabIndex = 7;
            this.walletLabel.Text = "0 rub";
            // 
            // numeric_sellAndInvest
            // 
            this.numeric_sellAndInvest.Location = new System.Drawing.Point(76, 311);
            this.numeric_sellAndInvest.Name = "numeric_sellAndInvest";
            this.numeric_sellAndInvest.ReadOnly = true;
            this.numeric_sellAndInvest.Size = new System.Drawing.Size(66, 22);
            this.numeric_sellAndInvest.TabIndex = 11;
            // 
            // brokerageLabel
            // 
            this.brokerageLabel.AutoSize = true;
            this.brokerageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brokerageLabel.Location = new System.Drawing.Point(171, 385);
            this.brokerageLabel.Name = "brokerageLabel";
            this.brokerageLabel.Size = new System.Drawing.Size(46, 17);
            this.brokerageLabel.TabIndex = 13;
            this.brokerageLabel.Text = "0 rub";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Brokerage account:";
            // 
            // numericStartCapital
            // 
            this.numericStartCapital.Location = new System.Drawing.Point(97, 113);
            this.numericStartCapital.Name = "numericStartCapital";
            this.numericStartCapital.Size = new System.Drawing.Size(120, 22);
            this.numericStartCapital.TabIndex = 14;
            this.numericStartCapital.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Start capital:";
            // 
            // invest_button
            // 
            this.invest_button.Location = new System.Drawing.Point(151, 305);
            this.invest_button.Name = "invest_button";
            this.invest_button.Size = new System.Drawing.Size(66, 33);
            this.invest_button.TabIndex = 16;
            this.invest_button.Text = "Invest";
            this.invest_button.UseVisualStyleBackColor = true;
            this.invest_button.Click += new System.EventHandler(this.invest_button_Click);
            // 
            // sell_button
            // 
            this.sell_button.Location = new System.Drawing.Point(8, 305);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(55, 33);
            this.sell_button.TabIndex = 17;
            this.sell_button.Text = "Sell";
            this.sell_button.UseVisualStyleBackColor = true;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Length of day in sec:";
            // 
            // numeric_dayLength
            // 
            this.numeric_dayLength.Location = new System.Drawing.Point(146, 150);
            this.numeric_dayLength.Name = "numeric_dayLength";
            this.numeric_dayLength.Size = new System.Drawing.Size(71, 22);
            this.numeric_dayLength.TabIndex = 19;
            this.numeric_dayLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_dayLength.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pause_button
            // 
            this.pause_button.Location = new System.Drawing.Point(8, 191);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(86, 28);
            this.pause_button.TabIndex = 20;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_label.Location = new System.Drawing.Point(119, 267);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(30, 25);
            this.day_label.TabIndex = 22;
            this.day_label.Text = "0 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(62, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Day:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 440);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.numeric_dayLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.invest_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericStartCapital);
            this.Controls.Add(this.brokerageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_sellAndInvest);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.walet);
            this.Controls.Add(this.numeric_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_initial_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_initial_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_sellAndInvest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dayLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_initial_price;
        private System.Windows.Forms.NumericUpDown numeric_days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label walet;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.NumericUpDown numeric_sellAndInvest;
        private System.Windows.Forms.Label brokerageLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericStartCapital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button invest_button;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_dayLength;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label label5;
    }
}

