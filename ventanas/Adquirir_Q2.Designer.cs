namespace mqtt_serial.ventanas
{
    partial class Adquirir_Q2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chargraficaQ2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxPWM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarPWM);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 601);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.comboBoxPWM.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.trackBarPWM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelCurrent);
            this.panel2.Controls.Add(this.labelTemperature);
            this.panel2.Location = new System.Drawing.Point(804, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 601);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.labelCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.chargraficaQ2);
            this.panel3.Location = new System.Drawing.Point(239, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 601);
            this.panel3.TabIndex = 3;
            // 
            // chargraficaQ2
            // 
            this.chargraficaQ2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chargraficaQ2.BackColor = System.Drawing.Color.Transparent;
            chartArea13.AxisX.InterlacedColor = System.Drawing.Color.Silver;
            chartArea13.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisX.MajorGrid.Interval = 0D;
            chartArea13.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea13.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea13.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea13.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea13.AxisX.MajorTickMark.Interval = 0D;
            chartArea13.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea13.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea13.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea13.AxisX.MaximumAutoSize = 100F;
            chartArea13.AxisX.ScrollBar.BackColor = System.Drawing.Color.Black;
            chartArea13.AxisX.Title = "time(s)";
            chartArea13.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea13.AxisX.ToolTip = "0";
            chartArea13.AxisX2.MaximumAutoSize = 100F;
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea13.AxisY.Title = "temperature  °C";
            chartArea13.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea13.BackColor = System.Drawing.Color.White;
            chartArea13.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea13.CursorX.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea13.CursorX.SelectionColor = System.Drawing.Color.Silver;
            chartArea13.Name = "ChartAreaTempPWM";
            chartArea14.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisX.Title = "time(s)";
            chartArea14.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea14.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisY.Title = "current  mA";
            chartArea14.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea14.BackColor = System.Drawing.Color.Gray;
            chartArea14.BackSecondaryColor = System.Drawing.Color.White;
            chartArea14.Name = "Corriente";
            this.chargraficaQ2.ChartAreas.Add(chartArea13);
            this.chargraficaQ2.ChartAreas.Add(chartArea14);
            legend13.BackColor = System.Drawing.Color.White;
            legend13.DockedToChartArea = "ChartAreaTempPWM";
            legend13.IsDockedInsideChartArea = false;
            legend13.Name = "Legend1";
            legend14.BackColor = System.Drawing.Color.White;
            legend14.DockedToChartArea = "Corriente";
            legend14.IsDockedInsideChartArea = false;
            legend14.Name = "Legend2";
            this.chargraficaQ2.Legends.Add(legend13);
            this.chargraficaQ2.Legends.Add(legend14);
            this.chargraficaQ2.Location = new System.Drawing.Point(0, 63);
            this.chargraficaQ2.Name = "chargraficaQ2";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartAreaTempPWM";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Color = System.Drawing.Color.Red;
            series19.EmptyPointStyle.Color = System.Drawing.Color.Black;
            series19.Legend = "Legend1";
            series19.Name = "Temperatura";
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartAreaTempPWM";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series20.Color = System.Drawing.Color.Teal;
            series20.Legend = "Legend1";
            series20.Name = "PWM";
            series21.BorderWidth = 3;
            series21.ChartArea = "Corriente";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Color = System.Drawing.Color.Blue;
            series21.Legend = "Legend2";
            series21.Name = "corriente";
            this.chargraficaQ2.Series.Add(series19);
            this.chargraficaQ2.Series.Add(series20);
            this.chargraficaQ2.Series.Add(series21);
            this.chargraficaQ2.Size = new System.Drawing.Size(564, 475);
            this.chargraficaQ2.TabIndex = 1;
            this.chargraficaQ2.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Adquirir_Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adquirir_Q2";
            this.Text = "Adquirir_Q2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adquirir_Q2_FormClosing);
            this.Load += new System.EventHandler(this.Adquirir_Q2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPWM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TrackBar trackBarPWM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTemperatura;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chargraficaQ2;
        private System.Windows.Forms.Timer timer1;
    }
}