namespace mqtt_serial
{
    partial class ControlActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlActual));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.comboBoxTs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKp = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.buttonRefrescar);
            this.groupBox3.Controls.Add(this.comboBoxTs);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxKd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxKi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxKp);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(254)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(38, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 273);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametros de Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "TS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonRefrescar.ForeColor = System.Drawing.Color.White;
            this.buttonRefrescar.Location = new System.Drawing.Point(6, 216);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(164, 52);
            this.buttonRefrescar.TabIndex = 17;
            this.buttonRefrescar.Text = "Refrescar Q1";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
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
            this.comboBoxTs.Location = new System.Drawing.Point(100, 173);
            this.comboBoxTs.Name = "comboBoxTs";
            this.comboBoxTs.Size = new System.Drawing.Size(109, 33);
            this.comboBoxTs.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 23;
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
            this.comboBoxKd.Location = new System.Drawing.Point(100, 128);
            this.comboBoxKd.Name = "comboBoxKd";
            this.comboBoxKd.Size = new System.Drawing.Size(109, 33);
            this.comboBoxKd.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 21;
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
            this.comboBoxKi.Location = new System.Drawing.Point(100, 83);
            this.comboBoxKi.Name = "comboBoxKi";
            this.comboBoxKi.Size = new System.Drawing.Size(110, 33);
            this.comboBoxKi.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 19;
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
            this.comboBoxKp.Location = new System.Drawing.Point(100, 38);
            this.comboBoxKp.Name = "comboBoxKp";
            this.comboBoxKp.Size = new System.Drawing.Size(110, 33);
            this.comboBoxKp.TabIndex = 20;
            // 
            // ControlActual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(309, 350);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 380);
            this.Name = "ControlActual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ControlActual_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.ComboBox comboBoxTs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxKd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKp;
    }
}