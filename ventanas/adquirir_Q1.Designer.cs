namespace mqtt_serial.ventanas
{
    partial class adquirir_Q1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPWM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPWM = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTemperatura = new System.Windows.Forms.ComboBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelCorriente2 = new System.Windows.Forms.Label();
            this.labelCorriente1 = new System.Windows.Forms.Label();
            this.labelTemperatura2 = new System.Windows.Forms.Label();
            this.labelTemperatura1 = new System.Windows.Forms.Label();
            this.chargraficaQ1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxPWM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarPWM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 601);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "%PWM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // comboBoxPWM
            // 
            this.comboBoxPWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxPWM.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPWM.FormatString = "N0";
            this.comboBoxPWM.FormattingEnabled = true;
            this.comboBoxPWM.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBoxPWM.Location = new System.Drawing.Point(12, 259);
            this.comboBoxPWM.Name = "comboBoxPWM";
            this.comboBoxPWM.Size = new System.Drawing.Size(75, 33);
            this.comboBoxPWM.TabIndex = 3;
            this.comboBoxPWM.SelectedIndexChanged += new System.EventHandler(this.comboBoxPWM_SelectedIndexChanged);
            this.comboBoxPWM.TextChanged += new System.EventHandler(this.comboBoxPWM_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "100%";
            // 
            // trackBarPWM
            // 
            this.trackBarPWM.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.trackBarPWM.Location = new System.Drawing.Point(137, 167);
            this.trackBarPWM.Maximum = 100;
            this.trackBarPWM.Name = "trackBarPWM";
            this.trackBarPWM.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPWM.Size = new System.Drawing.Size(45, 228);
            this.trackBarPWM.TabIndex = 0;
            this.trackBarPWM.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPWM.Scroll += new System.EventHandler(this.trackBarPWM_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelCurrent);
            this.panel2.Controls.Add(this.labelTemperature);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(804, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 601);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBoxTemperatura);
            this.panel4.Location = new System.Drawing.Point(28, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alarma";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(162, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "°C";
            // 
            // comboBoxTemperatura
            // 
            this.comboBoxTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxTemperatura.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTemperatura.FormatString = "N0";
            this.comboBoxTemperatura.FormattingEnabled = true;
            this.comboBoxTemperatura.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBoxTemperatura.Location = new System.Drawing.Point(83, 39);
            this.comboBoxTemperatura.Name = "comboBoxTemperatura";
            this.comboBoxTemperatura.Size = new System.Drawing.Size(75, 33);
            this.comboBoxTemperatura.TabIndex = 9;
            // 
            // labelCurrent
            // 
            this.labelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelCurrent.ForeColor = System.Drawing.Color.White;
            this.labelCurrent.Image = global::mqtt_serial.Properties.Resources.game_icons__electrical_resistance;
            this.labelCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCurrent.Location = new System.Drawing.Point(52, 184);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(150, 25);
            this.labelCurrent.TabIndex = 7;
            this.labelCurrent.Text = "Current";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperature
            // 
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Image = global::mqtt_serial.Properties.Resources.fluent__temperature_16_filled;
            this.labelTemperature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTemperature.Location = new System.Drawing.Point(52, 129);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTemperature.Size = new System.Drawing.Size(150, 35);
            this.labelTemperature.TabIndex = 6;
            this.labelTemperature.Text = "Temperature";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTiempo);
            this.panel3.Controls.Add(this.labelCorriente2);
            this.panel3.Controls.Add(this.labelCorriente1);
            this.panel3.Controls.Add(this.labelTemperatura2);
            this.panel3.Controls.Add(this.labelTemperatura1);
            this.panel3.Controls.Add(this.chargraficaQ1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 601);
            this.panel3.TabIndex = 2;
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.ForeColor = System.Drawing.Color.White;
            this.labelTiempo.Location = new System.Drawing.Point(366, 29);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(35, 13);
            this.labelTiempo.TabIndex = 5;
            this.labelTiempo.Text = "label5";
            // 
            // labelCorriente2
            // 
            this.labelCorriente2.AutoSize = true;
            this.labelCorriente2.ForeColor = System.Drawing.Color.White;
            this.labelCorriente2.Location = new System.Drawing.Point(254, 29);
            this.labelCorriente2.Name = "labelCorriente2";
            this.labelCorriente2.Size = new System.Drawing.Size(35, 13);
            this.labelCorriente2.TabIndex = 4;
            this.labelCorriente2.Text = "label5";
            // 
            // labelCorriente1
            // 
            this.labelCorriente1.AutoSize = true;
            this.labelCorriente1.ForeColor = System.Drawing.Color.White;
            this.labelCorriente1.Location = new System.Drawing.Point(176, 29);
            this.labelCorriente1.Name = "labelCorriente1";
            this.labelCorriente1.Size = new System.Drawing.Size(35, 13);
            this.labelCorriente1.TabIndex = 3;
            this.labelCorriente1.Text = "label5";
            // 
            // labelTemperatura2
            // 
            this.labelTemperatura2.AutoSize = true;
            this.labelTemperatura2.ForeColor = System.Drawing.Color.White;
            this.labelTemperatura2.Location = new System.Drawing.Point(99, 29);
            this.labelTemperatura2.Name = "labelTemperatura2";
            this.labelTemperatura2.Size = new System.Drawing.Size(35, 13);
            this.labelTemperatura2.TabIndex = 2;
            this.labelTemperatura2.Text = "label5";
            // 
            // labelTemperatura1
            // 
            this.labelTemperatura1.AutoSize = true;
            this.labelTemperatura1.ForeColor = System.Drawing.Color.White;
            this.labelTemperatura1.Location = new System.Drawing.Point(27, 29);
            this.labelTemperatura1.Name = "labelTemperatura1";
            this.labelTemperatura1.Size = new System.Drawing.Size(35, 13);
            this.labelTemperatura1.TabIndex = 1;
            this.labelTemperatura1.Text = "label5";
            // 
            // chargraficaQ1
            // 
            this.chargraficaQ1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "time(s)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.ToolTip = "0";
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "temperature  °C";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartAreaTempPWM";
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "time(s)";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.Title = "current  mA";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Gray;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "Corriente";
            this.chargraficaQ1.ChartAreas.Add(chartArea1);
            this.chargraficaQ1.ChartAreas.Add(chartArea2);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Name = "Legend2";
            legend2.Position.Auto = false;
            legend2.Position.Height = 8F;
            legend2.Position.Width = 20F;
            legend2.Position.X = 73F;
            legend2.Position.Y = 53F;
            this.chargraficaQ1.Legends.Add(legend1);
            this.chargraficaQ1.Legends.Add(legend2);
            this.chargraficaQ1.Location = new System.Drawing.Point(0, 65);
            this.chargraficaQ1.Name = "chargraficaQ1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartAreaTempPWM";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartAreaTempPWM";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Teal;
            series2.Legend = "Legend1";
            series2.Name = "PWM";
            series3.BorderWidth = 3;
            series3.ChartArea = "Corriente";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend2";
            series3.Name = "corriente";
            this.chargraficaQ1.Series.Add(series1);
            this.chargraficaQ1.Series.Add(series2);
            this.chargraficaQ1.Series.Add(series3);
            this.chargraficaQ1.Size = new System.Drawing.Size(564, 475);
            this.chargraficaQ1.TabIndex = 0;
            this.chargraficaQ1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adquirir_Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adquirir_Q1";
            this.Text = "adquirir_Q1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adquirir_Q1_FormClosing);
            this.Load += new System.EventHandler(this.adquirir_Q1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TrackBar trackBarPWM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPWM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chargraficaQ1;
        private System.Windows.Forms.ComboBox comboBoxTemperatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelCorriente2;
        private System.Windows.Forms.Label labelCorriente1;
        private System.Windows.Forms.Label labelTemperatura2;
        private System.Windows.Forms.Label labelTemperatura1;
        private System.Windows.Forms.Timer timer1;
    }
}