namespace mqtt_serial
{
    partial class pantalla_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_principal));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_adquiri_q1 = new System.Windows.Forms.Button();
            this.buttonControlQ1Q2 = new System.Windows.Forms.Button();
            this.button_adquiri_q2 = new System.Windows.Forms.Button();
            this.button_controlQ1 = new System.Windows.Forms.Button();
            this.button_conexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ventanas = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.text_ventana = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(77)))));
            this.panel_menu.Controls.Add(this.button_adquiri_q1);
            this.panel_menu.Controls.Add(this.buttonControlQ1Q2);
            this.panel_menu.Controls.Add(this.button_adquiri_q2);
            this.panel_menu.Controls.Add(this.button_controlQ1);
            this.panel_menu.Controls.Add(this.button_conexion);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Location = new System.Drawing.Point(0, 60);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(240, 640);
            this.panel_menu.TabIndex = 0;
            // 
            // button_adquiri_q1
            // 
            this.button_adquiri_q1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_adquiri_q1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_adquiri_q1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_adquiri_q1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_adquiri_q1.FlatAppearance.BorderSize = 0;
            this.button_adquiri_q1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adquiri_q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button_adquiri_q1.ForeColor = System.Drawing.Color.White;
            this.button_adquiri_q1.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.button_adquiri_q1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_adquiri_q1.Location = new System.Drawing.Point(19, 236);
            this.button_adquiri_q1.Margin = new System.Windows.Forms.Padding(0);
            this.button_adquiri_q1.Name = "button_adquiri_q1";
            this.button_adquiri_q1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.button_adquiri_q1.Size = new System.Drawing.Size(201, 73);
            this.button_adquiri_q1.TabIndex = 0;
            this.button_adquiri_q1.Text = "Adquirir \r\ndatos Q1";
            this.button_adquiri_q1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_adquiri_q1.UseVisualStyleBackColor = false;
            this.button_adquiri_q1.Click += new System.EventHandler(this.button_adquiri_q1_Click);
            // 
            // buttonControlQ1Q2
            // 
            this.buttonControlQ1Q2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1Q2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1Q2.FlatAppearance.BorderSize = 0;
            this.buttonControlQ1Q2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControlQ1Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonControlQ1Q2.ForeColor = System.Drawing.Color.White;
            this.buttonControlQ1Q2.Image = global::mqtt_serial.Properties.Resources.cbi__battery_temp;
            this.buttonControlQ1Q2.Location = new System.Drawing.Point(19, 485);
            this.buttonControlQ1Q2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonControlQ1Q2.Name = "buttonControlQ1Q2";
            this.buttonControlQ1Q2.Size = new System.Drawing.Size(201, 73);
            this.buttonControlQ1Q2.TabIndex = 0;
            this.buttonControlQ1Q2.Text = "Control \r\nQ1 y Q2";
            this.buttonControlQ1Q2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonControlQ1Q2.UseVisualStyleBackColor = true;
            this.buttonControlQ1Q2.Click += new System.EventHandler(this.buttonControlQ1Q2_Click);
            // 
            // button_adquiri_q2
            // 
            this.button_adquiri_q2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_adquiri_q2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_adquiri_q2.FlatAppearance.BorderSize = 0;
            this.button_adquiri_q2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adquiri_q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button_adquiri_q2.ForeColor = System.Drawing.Color.White;
            this.button_adquiri_q2.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.button_adquiri_q2.Location = new System.Drawing.Point(19, 402);
            this.button_adquiri_q2.Margin = new System.Windows.Forms.Padding(2);
            this.button_adquiri_q2.Name = "button_adquiri_q2";
            this.button_adquiri_q2.Size = new System.Drawing.Size(201, 73);
            this.button_adquiri_q2.TabIndex = 5;
            this.button_adquiri_q2.Text = "Adquirir \r\ndatos Q2";
            this.button_adquiri_q2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_adquiri_q2.UseVisualStyleBackColor = false;
            this.button_adquiri_q2.Click += new System.EventHandler(this.button_adquiri_q2_Click);
            // 
            // button_controlQ1
            // 
            this.button_controlQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_controlQ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_controlQ1.FlatAppearance.BorderSize = 0;
            this.button_controlQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_controlQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button_controlQ1.ForeColor = System.Drawing.Color.White;
            this.button_controlQ1.Image = global::mqtt_serial.Properties.Resources.cbi__battery_temp;
            this.button_controlQ1.Location = new System.Drawing.Point(19, 319);
            this.button_controlQ1.Margin = new System.Windows.Forms.Padding(2);
            this.button_controlQ1.Name = "button_controlQ1";
            this.button_controlQ1.Size = new System.Drawing.Size(201, 73);
            this.button_controlQ1.TabIndex = 4;
            this.button_controlQ1.Text = "Control Q1";
            this.button_controlQ1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_controlQ1.UseVisualStyleBackColor = false;
            this.button_controlQ1.Click += new System.EventHandler(this.button_controlQ1_Click);
            // 
            // button_conexion
            // 
            this.button_conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_conexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.button_conexion.FlatAppearance.BorderSize = 0;
            this.button_conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.button_conexion.ForeColor = System.Drawing.Color.White;
            this.button_conexion.Image = global::mqtt_serial.Properties.Resources.icon_park_outline__connection_box;
            this.button_conexion.Location = new System.Drawing.Point(19, 153);
            this.button_conexion.Name = "button_conexion";
            this.button_conexion.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.button_conexion.Size = new System.Drawing.Size(201, 70);
            this.button_conexion.TabIndex = 1;
            this.button_conexion.Text = "Conexion";
            this.button_conexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_conexion.UseVisualStyleBackColor = false;
            this.button_conexion.Click += new System.EventHandler(this.button_conexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_ventanas
            // 
            this.panel_ventanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ventanas.Location = new System.Drawing.Point(240, 60);
            this.panel_ventanas.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ventanas.Name = "panel_ventanas";
            this.panel_ventanas.Size = new System.Drawing.Size(1060, 640);
            this.panel_ventanas.TabIndex = 1;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.panel_top.Controls.Add(this.pictureBoxLogo);
            this.panel_top.Controls.Add(this.text_ventana);
            this.panel_top.Controls.Add(this.button_minimizar);
            this.panel_top.Controls.Add(this.button_Cerrar);
            this.panel_top.Location = new System.Drawing.Point(1, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1300, 60);
            this.panel_top.TabIndex = 2;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::mqtt_serial.Properties.Resources.Gemini_Generated_Image_11vvqd11vvqd11vv;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseMove);
            // 
            // text_ventana
            // 
            this.text_ventana.AutoSize = true;
            this.text_ventana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ventana.ForeColor = System.Drawing.Color.White;
            this.text_ventana.Location = new System.Drawing.Point(401, 15);
            this.text_ventana.Name = "text_ventana";
            this.text_ventana.Size = new System.Drawing.Size(548, 31);
            this.text_ventana.TabIndex = 2;
            this.text_ventana.Text = "Software de control IOT con MQTT y ESP32";
            this.text_ventana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.text_ventana_MouseMove);
            // 
            // button_minimizar
            // 
            this.button_minimizar.BackColor = System.Drawing.Color.Maroon;
            this.button_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(1156, 5);
            this.button_minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(50, 50);
            this.button_minimizar.TabIndex = 1;
            this.button_minimizar.Text = "-";
            this.button_minimizar.UseVisualStyleBackColor = false;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.BackColor = System.Drawing.Color.Red;
            this.button_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cerrar.ForeColor = System.Drawing.Color.White;
            this.button_Cerrar.Location = new System.Drawing.Point(1226, 5);
            this.button_Cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(50, 50);
            this.button_Cerrar.TabIndex = 0;
            this.button_Cerrar.Text = "X";
            this.button_Cerrar.UseVisualStyleBackColor = false;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_ventanas);
            this.Controls.Add(this.panel_menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "pantalla_principal";
            this.Text = "Software de control IOT con MQTT y ESP32";
            this.Load += new System.EventHandler(this.pantalla_principal_Load);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_conexion;
        private System.Windows.Forms.Button button_adquiri_q2;
        private System.Windows.Forms.Button button_controlQ1;
        private System.Windows.Forms.Button button_adquiri_q1;
        private System.Windows.Forms.Button buttonControlQ1Q2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_ventanas;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Label text_ventana;
        private System.Windows.Forms.Button button_minimizar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

