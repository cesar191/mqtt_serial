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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.text_ventana = new System.Windows.Forms.Label();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUni)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(77)))));
            this.panel_menu.Controls.Add(this.buttonAdquiriQ1);
            this.panel_menu.Controls.Add(this.buttonControlQ1Q2);
            this.panel_menu.Controls.Add(this.buttonAdquiriQ2);
            this.panel_menu.Controls.Add(this.buttonControlQ1);
            this.panel_menu.Controls.Add(this.buttonConexion);
            this.panel_menu.Controls.Add(this.pictureBoxLogoUni);
            this.panel_menu.Location = new System.Drawing.Point(0, 60);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(240, 640);
            this.panel_menu.TabIndex = 0;
            // 
            // buttonAdquiriQ1
            // 
            this.buttonAdquiriQ1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdquiriQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdquiriQ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ1.FlatAppearance.BorderSize = 0;
            this.buttonAdquiriQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdquiriQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonAdquiriQ1.ForeColor = System.Drawing.Color.White;
            this.buttonAdquiriQ1.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.buttonAdquiriQ1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdquiriQ1.Location = new System.Drawing.Point(19, 236);
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
            // buttonAdquiriQ2
            // 
            this.buttonAdquiriQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonAdquiriQ2.FlatAppearance.BorderSize = 0;
            this.buttonAdquiriQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdquiriQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonAdquiriQ2.ForeColor = System.Drawing.Color.White;
            this.buttonAdquiriQ2.Image = global::mqtt_serial.Properties.Resources.hugeicons__chart;
            this.buttonAdquiriQ2.Location = new System.Drawing.Point(19, 402);
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
            this.buttonControlQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonControlQ1.FlatAppearance.BorderSize = 0;
            this.buttonControlQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControlQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonControlQ1.ForeColor = System.Drawing.Color.White;
            this.buttonControlQ1.Image = global::mqtt_serial.Properties.Resources.cbi__battery_temp;
            this.buttonControlQ1.Location = new System.Drawing.Point(19, 319);
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
            this.buttonConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonConexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(7)))), ((int)(((byte)(88)))));
            this.buttonConexion.FlatAppearance.BorderSize = 0;
            this.buttonConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonConexion.ForeColor = System.Drawing.Color.White;
            this.buttonConexion.Image = global::mqtt_serial.Properties.Resources.icon_park_outline__connection_box;
            this.buttonConexion.Location = new System.Drawing.Point(19, 153);
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
            this.pictureBoxLogoUni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogoUni.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoUni.Image")));
            this.pictureBoxLogoUni.Location = new System.Drawing.Point(19, 83);
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
            this.panel_ventanas.Location = new System.Drawing.Point(240, 60);
            this.panel_ventanas.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ventanas.Name = "panel_ventanas";
            this.panel_ventanas.Size = new System.Drawing.Size(1060, 640);
            this.panel_ventanas.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Controls.Add(this.text_ventana);
            this.panelTop.Controls.Add(this.buttonMinimizar);
            this.panelTop.Controls.Add(this.buttonCerrar);
            this.panelTop.Location = new System.Drawing.Point(1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 60);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
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
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackColor = System.Drawing.Color.Maroon;
            this.buttonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimizar.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizar.Location = new System.Drawing.Point(1156, 5);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(50, 50);
            this.buttonMinimizar.TabIndex = 1;
            this.buttonMinimizar.Text = "-";
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(1226, 5);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(50, 50);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panelTop);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pantalla_principal_FormClosing);
            this.Load += new System.EventHandler(this.pantalla_principal_Load);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUni)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label text_ventana;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

