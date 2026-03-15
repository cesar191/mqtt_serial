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
            this.buttonAdquiriQ1 = new System.Windows.Forms.Button();
            this.buttonControlQ1Q2 = new System.Windows.Forms.Button();
            this.buttonAdquiriQ2 = new System.Windows.Forms.Button();
            this.buttonControlQ1 = new System.Windows.Forms.Button();
            this.buttonConexion = new System.Windows.Forms.Button();
            this.pictureBoxLogoUni = new System.Windows.Forms.PictureBox();
            this.panel_ventanas = new System.Windows.Forms.Panel();
            this.buttonEstadoConexion = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUni)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(77)))));
            this.panel_menu.Controls.Add(this.buttonEstadoConexion);
            this.panel_menu.Controls.Add(this.buttonAdquiriQ1);
            this.panel_menu.Controls.Add(this.buttonControlQ1Q2);
            this.panel_menu.Controls.Add(this.buttonAdquiriQ2);
            this.panel_menu.Controls.Add(this.buttonControlQ1);
            this.panel_menu.Controls.Add(this.buttonConexion);
            this.panel_menu.Controls.Add(this.pictureBoxLogoUni);
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(240, 700);
            this.panel_menu.TabIndex = 0;
            // 
            // buttonAdquiriQ1
            // 
            this.buttonAdquiriQ1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdquiriQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdquiriQ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ1.FlatAppearance.BorderSize = 0;
            this.buttonAdquiriQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdquiriQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonAdquiriQ1.ForeColor = System.Drawing.Color.White;
            this.buttonAdquiriQ1.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.buttonAdquiriQ1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdquiriQ1.Location = new System.Drawing.Point(19, 235);
            this.buttonAdquiriQ1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdquiriQ1.Name = "buttonAdquiriQ1";
            this.buttonAdquiriQ1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonAdquiriQ1.Size = new System.Drawing.Size(201, 73);
            this.buttonAdquiriQ1.TabIndex = 0;
            this.buttonAdquiriQ1.Text = "Adquirir \r\ndatos Q1";
            this.buttonAdquiriQ1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdquiriQ1.UseVisualStyleBackColor = false;
            this.buttonAdquiriQ1.Click += new System.EventHandler(this.button_adquiri_q1_Click);
            // 
            // buttonControlQ1Q2
            // 
            this.buttonControlQ1Q2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonControlQ1Q2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1Q2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1Q2.FlatAppearance.BorderSize = 0;
            this.buttonControlQ1Q2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControlQ1Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonControlQ1Q2.ForeColor = System.Drawing.Color.White;
            this.buttonControlQ1Q2.Image = global::mqtt_serial.Properties.Resources.cbi__battery_temp;
            this.buttonControlQ1Q2.Location = new System.Drawing.Point(19, 475);
            this.buttonControlQ1Q2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonControlQ1Q2.Name = "buttonControlQ1Q2";
            this.buttonControlQ1Q2.Size = new System.Drawing.Size(201, 73);
            this.buttonControlQ1Q2.TabIndex = 0;
            this.buttonControlQ1Q2.Text = "Control \r\nQ1 y Q2";
            this.buttonControlQ1Q2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonControlQ1Q2.UseVisualStyleBackColor = true;
            this.buttonControlQ1Q2.Click += new System.EventHandler(this.buttonControlQ1Q2_Click);
            // 
            // buttonAdquiriQ2
            // 
            this.buttonAdquiriQ2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdquiriQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ2.FlatAppearance.BorderSize = 0;
            this.buttonAdquiriQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdquiriQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonAdquiriQ2.ForeColor = System.Drawing.Color.White;
            this.buttonAdquiriQ2.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.buttonAdquiriQ2.Location = new System.Drawing.Point(20, 395);
            this.buttonAdquiriQ2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdquiriQ2.Name = "buttonAdquiriQ2";
            this.buttonAdquiriQ2.Size = new System.Drawing.Size(201, 73);
            this.buttonAdquiriQ2.TabIndex = 5;
            this.buttonAdquiriQ2.Text = "Adquirir \r\ndatos Q2";
            this.buttonAdquiriQ2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdquiriQ2.UseVisualStyleBackColor = false;
            this.buttonAdquiriQ2.Click += new System.EventHandler(this.button_adquiri_q2_Click);
            // 
            // buttonControlQ1
            // 
            this.buttonControlQ1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonControlQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1.FlatAppearance.BorderSize = 0;
            this.buttonControlQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControlQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonControlQ1.ForeColor = System.Drawing.Color.White;
            this.buttonControlQ1.Image = global::mqtt_serial.Properties.Resources.cbi__battery_temp;
            this.buttonControlQ1.Location = new System.Drawing.Point(19, 315);
            this.buttonControlQ1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonControlQ1.Name = "buttonControlQ1";
            this.buttonControlQ1.Size = new System.Drawing.Size(201, 73);
            this.buttonControlQ1.TabIndex = 4;
            this.buttonControlQ1.Text = "Control Q1";
            this.buttonControlQ1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonControlQ1.UseVisualStyleBackColor = false;
            this.buttonControlQ1.Click += new System.EventHandler(this.button_controlQ1_Click);
            // 
            // buttonConexion
            // 
            this.buttonConexion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonConexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonConexion.FlatAppearance.BorderSize = 0;
            this.buttonConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonConexion.ForeColor = System.Drawing.Color.White;
            this.buttonConexion.Image = global::mqtt_serial.Properties.Resources.icon_park_outline__connection_box;
            this.buttonConexion.Location = new System.Drawing.Point(19, 155);
            this.buttonConexion.Name = "buttonConexion";
            this.buttonConexion.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.buttonConexion.Size = new System.Drawing.Size(201, 70);
            this.buttonConexion.TabIndex = 1;
            this.buttonConexion.Text = "Conexion";
            this.buttonConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConexion.UseVisualStyleBackColor = false;
            this.buttonConexion.Click += new System.EventHandler(this.button_conexion_Click);
            // 
            // pictureBoxLogoUni
            // 
            this.pictureBoxLogoUni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLogoUni.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoUni.Image")));
            this.pictureBoxLogoUni.Location = new System.Drawing.Point(19, 78);
            this.pictureBoxLogoUni.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogoUni.Name = "pictureBoxLogoUni";
            this.pictureBoxLogoUni.Size = new System.Drawing.Size(202, 52);
            this.pictureBoxLogoUni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoUni.TabIndex = 1;
            this.pictureBoxLogoUni.TabStop = false;
            // 
            // panel_ventanas
            // 
            this.panel_ventanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ventanas.Location = new System.Drawing.Point(240, 0);
            this.panel_ventanas.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ventanas.Name = "panel_ventanas";
            this.panel_ventanas.Size = new System.Drawing.Size(1060, 700);
            this.panel_ventanas.TabIndex = 1;
            // 
            // buttonEstadoConexion
            // 
            this.buttonEstadoConexion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEstadoConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(58)))), ((int)(((byte)(24)))));
            this.buttonEstadoConexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonEstadoConexion.ForeColor = System.Drawing.Color.White;
            this.buttonEstadoConexion.Location = new System.Drawing.Point(19, 587);
            this.buttonEstadoConexion.Name = "buttonEstadoConexion";
            this.buttonEstadoConexion.Size = new System.Drawing.Size(200, 70);
            this.buttonEstadoConexion.TabIndex = 6;
            this.buttonEstadoConexion.Text = "Desconectar";
            this.buttonEstadoConexion.UseVisualStyleBackColor = false;
            this.buttonEstadoConexion.Click += new System.EventHandler(this.buttonEstadoConexion_Click);
            // 
            // pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel_ventanas);
            this.Controls.Add(this.panel_menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "pantalla_principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Software de control IOT con MQTT y ESP32";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pantalla_principal_FormClosing);
            this.Load += new System.EventHandler(this.pantalla_principal_Load);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button buttonConexion;
        private System.Windows.Forms.Button buttonAdquiriQ2;
        private System.Windows.Forms.Button buttonControlQ1;
        private System.Windows.Forms.Button buttonAdquiriQ1;
        private System.Windows.Forms.Button buttonControlQ1Q2;
        private System.Windows.Forms.PictureBox pictureBoxLogoUni;
        private System.Windows.Forms.Panel panel_ventanas;
        private System.Windows.Forms.Button buttonEstadoConexion;
    }
}

