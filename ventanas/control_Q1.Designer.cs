namespace mqtt_serial.ventanas
{
    partial class control_Q1
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
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.comboBoxSetPoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKp = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxVentilador = new System.Windows.Forms.PictureBox();
            this.buttonVentilador = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTemperatura = new System.Windows.Forms.ComboBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPWM = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.chargraficaQ1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentilador)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefrescar);
            this.panel1.Controls.Add(this.comboBoxSetPoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 601);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonRefrescar.Location = new System.Drawing.Point(12, 425);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(200, 50);
            this.buttonRefrescar.TabIndex = 17;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // comboBoxSetPoint
            // 
            this.comboBoxSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxSetPoint.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSetPoint.FormatString = "N0";
            this.comboBoxSetPoint.FormattingEnabled = true;
            this.comboBoxSetPoint.Items.AddRange(new object[] {
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
            this.comboBoxSetPoint.Location = new System.Drawing.Point(108, 69);
            this.comboBoxSetPoint.Name = "comboBoxSetPoint";
            this.comboBoxSetPoint.Size = new System.Drawing.Size(110, 33);
            this.comboBoxSetPoint.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "SetPoint";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.comboBoxTs);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboBoxKd);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBoxKi);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.comboBoxKp);
            this.panel5.Location = new System.Drawing.Point(12, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 248);
            this.panel5.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "TS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxTs
            // 
            this.comboBoxTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxTs.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTs.FormatString = "N0";
            this.comboBoxTs.FormattingEnabled = true;
            this.comboBoxTs.Items.AddRange(new object[] {
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
            this.comboBoxTs.Location = new System.Drawing.Point(49, 192);
            this.comboBoxTs.Name = "comboBoxTs";
            this.comboBoxTs.Size = new System.Drawing.Size(109, 33);
            this.comboBoxTs.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "KD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxKd
            // 
            this.comboBoxKd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxKd.ForeColor = System.Drawing.Color.Black;
            this.comboBoxKd.FormatString = "N0";
            this.comboBoxKd.FormattingEnabled = true;
            this.comboBoxKd.Items.AddRange(new object[] {
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
            this.comboBoxKd.Location = new System.Drawing.Point(49, 143);
            this.comboBoxKd.Name = "comboBoxKd";
            this.comboBoxKd.Size = new System.Drawing.Size(109, 33);
            this.comboBoxKd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "KI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxKi
            // 
            this.comboBoxKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxKi.ForeColor = System.Drawing.Color.Black;
            this.comboBoxKi.FormatString = "N0";
            this.comboBoxKi.FormattingEnabled = true;
            this.comboBoxKi.Items.AddRange(new object[] {
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
            this.comboBoxKi.Location = new System.Drawing.Point(48, 92);
            this.comboBoxKi.Name = "comboBoxKi";
            this.comboBoxKi.Size = new System.Drawing.Size(110, 33);
            this.comboBoxKi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "KP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxKp
            // 
            this.comboBoxKp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxKp.ForeColor = System.Drawing.Color.Black;
            this.comboBoxKp.FormatString = "N0";
            this.comboBoxKp.FormattingEnabled = true;
            this.comboBoxKp.Items.AddRange(new object[] {
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
            this.comboBoxKp.Location = new System.Drawing.Point(48, 39);
            this.comboBoxKp.Name = "comboBoxKp";
            this.comboBoxKp.Size = new System.Drawing.Size(110, 33);
            this.comboBoxKp.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxVentilador);
            this.panel3.Controls.Add(this.buttonVentilador);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelCurrent);
            this.panel3.Controls.Add(this.labelTemperature);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(804, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 601);
            this.panel3.TabIndex = 2;
            // 
            // pictureBoxVentilador
            // 
            this.pictureBoxVentilador.Image = global::mqtt_serial.Properties.Resources.ventilador_off;
            this.pictureBoxVentilador.Location = new System.Drawing.Point(35, 340);
            this.pictureBoxVentilador.Name = "pictureBoxVentilador";
            this.pictureBoxVentilador.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxVentilador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVentilador.TabIndex = 15;
            this.pictureBoxVentilador.TabStop = false;
            // 
            // buttonVentilador
            // 
            this.buttonVentilador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(169)))), ((int)(((byte)(94)))));
            this.buttonVentilador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVentilador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVentilador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonVentilador.ForeColor = System.Drawing.Color.White;
            this.buttonVentilador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentilador.Location = new System.Drawing.Point(94, 340);
            this.buttonVentilador.Name = "buttonVentilador";
            this.buttonVentilador.Size = new System.Drawing.Size(130, 52);
            this.buttonVentilador.TabIndex = 14;
            this.buttonVentilador.Text = "Encender";
            this.buttonVentilador.UseVisualStyleBackColor = false;
            this.buttonVentilador.Click += new System.EventHandler(this.buttonVentilador_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBoxTemperatura);
            this.panel4.Location = new System.Drawing.Point(27, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 13;
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
            this.labelCurrent.Location = new System.Drawing.Point(51, 152);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(150, 25);
            this.labelCurrent.TabIndex = 12;
            this.labelCurrent.Text = "Current";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperature
            // 
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Image = global::mqtt_serial.Properties.Resources.fluent__temperature_16_filled;
            this.labelTemperature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTemperature.Location = new System.Drawing.Point(51, 97);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTemperature.Size = new System.Drawing.Size(150, 35);
            this.labelTemperature.TabIndex = 11;
            this.labelTemperature.Text = "    Temperature";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPWM);
            this.panel2.Controls.Add(this.labelError2);
            this.panel2.Controls.Add(this.labelError1);
            this.panel2.Controls.Add(this.labelError);
            this.panel2.Controls.Add(this.chargraficaQ1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 601);
            this.panel2.TabIndex = 3;
            // 
            // labelPWM
            // 
            this.labelPWM.AutoSize = true;
            this.labelPWM.ForeColor = System.Drawing.Color.White;
            this.labelPWM.Location = new System.Drawing.Point(283, 30);
            this.labelPWM.Name = "labelPWM";
            this.labelPWM.Size = new System.Drawing.Size(35, 13);
            this.labelPWM.TabIndex = 6;
            this.labelPWM.Text = "label6";
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.White;
            this.labelError2.Location = new System.Drawing.Point(211, 30);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(35, 13);
            this.labelError2.TabIndex = 5;
            this.labelError2.Text = "label6";
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.White;
            this.labelError1.Location = new System.Drawing.Point(120, 30);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(35, 13);
            this.labelError1.TabIndex = 4;
            this.labelError1.Text = "label6";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(46, 30);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(35, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "label6";
            // 
            // chargraficaQ1
            // 
            this.chargraficaQ1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
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
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "time(s)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.ToolTip = "0";
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "temperature  °C";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.CursorX.LineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.PaleGoldenrod;
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
            legend2.Position.X = 76F;
            legend2.Position.Y = 53F;
            this.chargraficaQ1.Legends.Add(legend1);
            this.chargraficaQ1.Legends.Add(legend2);
            this.chargraficaQ1.Location = new System.Drawing.Point(0, 63);
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
            series2.Color = System.Drawing.Color.Cyan;
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
            this.chargraficaQ1.Size = new System.Drawing.Size(564, 476);
            this.chargraficaQ1.TabIndex = 1;
            this.chargraficaQ1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // control_Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "control_Q1";
            this.Text = "control_Q1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.control_Q1_FormClosing);
            this.Load += new System.EventHandler(this.control_Q1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentilador)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chargraficaQ1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTemperatura;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Button buttonVentilador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chargraficaQ1;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.ComboBox comboBoxSetPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxKd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labelPWM;
        private System.Windows.Forms.PictureBox pictureBoxVentilador;
    }
}