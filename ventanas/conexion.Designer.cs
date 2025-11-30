namespace mqtt_serial.ventanas
{
    partial class conexion
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
            this.paneldatos = new System.Windows.Forms.Panel();
            this.panel_user_pass = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelNameuser = new System.Windows.Forms.Label();
            this.panel_ip_serial = new System.Windows.Forms.Panel();
            this.label_Conexion_Baudio = new System.Windows.Forms.Label();
            this.comboBoxConexionBaudio = new System.Windows.Forms.ComboBox();
            this.comboBoxIPCOM = new System.Windows.Forms.ComboBox();
            this.label_IP_COM = new System.Windows.Forms.Label();
            this.panel_conexion = new System.Windows.Forms.Panel();
            this.buttonrefrescar = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.comboBoxTipoConexion = new System.Windows.Forms.ComboBox();
            this.labelTexconexion = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.paneldatos.SuspendLayout();
            this.panel_user_pass.SuspendLayout();
            this.panel_ip_serial.SuspendLayout();
            this.panel_conexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldatos
            // 
            this.paneldatos.Controls.Add(this.panel_user_pass);
            this.paneldatos.Controls.Add(this.panel_ip_serial);
            this.paneldatos.Controls.Add(this.panel_conexion);
            this.paneldatos.Controls.Add(this.comboBoxTipoConexion);
            this.paneldatos.Controls.Add(this.labelTexconexion);
            this.paneldatos.Location = new System.Drawing.Point(334, 151);
            this.paneldatos.Margin = new System.Windows.Forms.Padding(2);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(437, 344);
            this.paneldatos.TabIndex = 0;
            // 
            // panel_user_pass
            // 
            this.panel_user_pass.Controls.Add(this.textBoxPass);
            this.panel_user_pass.Controls.Add(this.textBoxName);
            this.panel_user_pass.Controls.Add(this.labelpassword);
            this.panel_user_pass.Controls.Add(this.labelNameuser);
            this.panel_user_pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_pass.Location = new System.Drawing.Point(0, 158);
            this.panel_user_pass.Name = "panel_user_pass";
            this.panel_user_pass.Size = new System.Drawing.Size(437, 100);
            this.panel_user_pass.TabIndex = 7;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(234, 31);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(200, 30);
            this.textBoxPass.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(0, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 30);
            this.textBoxName.TabIndex = 5;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.White;
            this.labelpassword.Location = new System.Drawing.Point(234, 3);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(114, 25);
            this.labelpassword.TabIndex = 4;
            this.labelpassword.Text = "Contraseña";
            // 
            // labelNameuser
            // 
            this.labelNameuser.AutoSize = true;
            this.labelNameuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelNameuser.ForeColor = System.Drawing.Color.White;
            this.labelNameuser.Location = new System.Drawing.Point(0, 3);
            this.labelNameuser.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameuser.Name = "labelNameuser";
            this.labelNameuser.Size = new System.Drawing.Size(110, 25);
            this.labelNameuser.TabIndex = 1;
            this.labelNameuser.Text = "Name User";
            // 
            // panel_ip_serial
            // 
            this.panel_ip_serial.Controls.Add(this.label_Conexion_Baudio);
            this.panel_ip_serial.Controls.Add(this.comboBoxConexionBaudio);
            this.panel_ip_serial.Controls.Add(this.comboBoxIPCOM);
            this.panel_ip_serial.Controls.Add(this.label_IP_COM);
            this.panel_ip_serial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ip_serial.Location = new System.Drawing.Point(0, 58);
            this.panel_ip_serial.Name = "panel_ip_serial";
            this.panel_ip_serial.Size = new System.Drawing.Size(437, 100);
            this.panel_ip_serial.TabIndex = 6;
            // 
            // label_Conexion_Baudio
            // 
            this.label_Conexion_Baudio.AutoSize = true;
            this.label_Conexion_Baudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label_Conexion_Baudio.ForeColor = System.Drawing.Color.White;
            this.label_Conexion_Baudio.Location = new System.Drawing.Point(234, 20);
            this.label_Conexion_Baudio.Name = "label_Conexion_Baudio";
            this.label_Conexion_Baudio.Size = new System.Drawing.Size(114, 25);
            this.label_Conexion_Baudio.TabIndex = 3;
            this.label_Conexion_Baudio.Text = "Nombre PC";
            // 
            // comboBoxConexionBaudio
            // 
            this.comboBoxConexionBaudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxConexionBaudio.FormattingEnabled = true;
            this.comboBoxConexionBaudio.Location = new System.Drawing.Point(234, 48);
            this.comboBoxConexionBaudio.Name = "comboBoxConexionBaudio";
            this.comboBoxConexionBaudio.Size = new System.Drawing.Size(200, 33);
            this.comboBoxConexionBaudio.TabIndex = 2;
            // 
            // comboBoxIPCOM
            // 
            this.comboBoxIPCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxIPCOM.FormattingEnabled = true;
            this.comboBoxIPCOM.Location = new System.Drawing.Point(0, 48);
            this.comboBoxIPCOM.Name = "comboBoxIPCOM";
            this.comboBoxIPCOM.Size = new System.Drawing.Size(200, 33);
            this.comboBoxIPCOM.TabIndex = 1;
            // 
            // label_IP_COM
            // 
            this.label_IP_COM.AutoSize = true;
            this.label_IP_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label_IP_COM.ForeColor = System.Drawing.Color.White;
            this.label_IP_COM.Location = new System.Drawing.Point(0, 20);
            this.label_IP_COM.Name = "label_IP_COM";
            this.label_IP_COM.Size = new System.Drawing.Size(116, 25);
            this.label_IP_COM.TabIndex = 0;
            this.label_IP_COM.Text = "Dirección IP";
            // 
            // panel_conexion
            // 
            this.panel_conexion.Controls.Add(this.buttonrefrescar);
            this.panel_conexion.Controls.Add(this.buttonConectar);
            this.panel_conexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_conexion.Location = new System.Drawing.Point(0, 271);
            this.panel_conexion.Name = "panel_conexion";
            this.panel_conexion.Size = new System.Drawing.Size(437, 73);
            this.panel_conexion.TabIndex = 5;
            // 
            // buttonrefrescar
            // 
            this.buttonrefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonrefrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonrefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonrefrescar.ForeColor = System.Drawing.Color.White;
            this.buttonrefrescar.Location = new System.Drawing.Point(287, 0);
            this.buttonrefrescar.Name = "buttonrefrescar";
            this.buttonrefrescar.Size = new System.Drawing.Size(150, 73);
            this.buttonrefrescar.TabIndex = 1;
            this.buttonrefrescar.Text = "Refrescar";
            this.buttonrefrescar.UseVisualStyleBackColor = false;
            this.buttonrefrescar.Click += new System.EventHandler(this.buttonrefrescar_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(169)))), ((int)(((byte)(94)))));
            this.buttonConectar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.buttonConectar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonConectar.Location = new System.Drawing.Point(0, 0);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(150, 73);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            // 
            // comboBoxTipoConexion
            // 
            this.comboBoxTipoConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTipoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.comboBoxTipoConexion.FormattingEnabled = true;
            this.comboBoxTipoConexion.Items.AddRange(new object[] {
            "MQTT (local)",
            "MQTT (servidor)",
            "Serial"});
            this.comboBoxTipoConexion.Location = new System.Drawing.Point(0, 25);
            this.comboBoxTipoConexion.Name = "comboBoxTipoConexion";
            this.comboBoxTipoConexion.Size = new System.Drawing.Size(437, 33);
            this.comboBoxTipoConexion.TabIndex = 2;
            this.comboBoxTipoConexion.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoConexion_SelectedIndexChanged);
            // 
            // labelTexconexion
            // 
            this.labelTexconexion.AutoSize = true;
            this.labelTexconexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTexconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.labelTexconexion.ForeColor = System.Drawing.Color.White;
            this.labelTexconexion.Location = new System.Drawing.Point(0, 0);
            this.labelTexconexion.Name = "labelTexconexion";
            this.labelTexconexion.Size = new System.Drawing.Size(162, 25);
            this.labelTexconexion.TabIndex = 0;
            this.labelTexconexion.Text = "Tipo de conexión";
            // 
            // conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1060, 640);
            this.Controls.Add(this.paneldatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conexion";
            this.paneldatos.ResumeLayout(false);
            this.paneldatos.PerformLayout();
            this.panel_user_pass.ResumeLayout(false);
            this.panel_user_pass.PerformLayout();
            this.panel_ip_serial.ResumeLayout(false);
            this.panel_ip_serial.PerformLayout();
            this.panel_conexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldatos;
        private System.Windows.Forms.Label labelTexconexion;
        private System.Windows.Forms.ComboBox comboBoxTipoConexion;
        private System.Windows.Forms.Panel panel_conexion;
        private System.Windows.Forms.Button buttonrefrescar;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Panel panel_user_pass;
        private System.Windows.Forms.Panel panel_ip_serial;
        private System.Windows.Forms.Label label_IP_COM;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelNameuser;
        private System.Windows.Forms.Label label_Conexion_Baudio;
        private System.Windows.Forms.ComboBox comboBoxConexionBaudio;
        private System.Windows.Forms.ComboBox comboBoxIPCOM;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.IO.Ports.SerialPort serialPort1;
    }
}