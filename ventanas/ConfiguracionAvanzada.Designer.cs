namespace mqtt_serial.ventanas
{
    partial class ConfiguracionAvanzada
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
            this.dataGridViewTopicos = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelBotonesSeguridad = new System.Windows.Forms.Panel();
            this.buttonClienteCall = new System.Windows.Forms.Button();
            this.buttonCertificadoCert = new System.Windows.Forms.Button();
            this.buttonCertificadoCA = new System.Windows.Forms.Button();
            this.panelTopic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarTopic = new System.Windows.Forms.Button();
            this.textBoxTopicoModifica = new System.Windows.Forms.TextBox();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonModificarClientID = new System.Windows.Forms.Button();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopicos)).BeginInit();
            this.panelBotonesSeguridad.SuspendLayout();
            this.panelTopic.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTopicos
            // 
            this.dataGridViewTopicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTopicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTopicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.Variable,
            this.tarea});
            this.dataGridViewTopicos.Location = new System.Drawing.Point(36, 241);
            this.dataGridViewTopicos.MultiSelect = false;
            this.dataGridViewTopicos.Name = "dataGridViewTopicos";
            this.dataGridViewTopicos.Size = new System.Drawing.Size(767, 226);
            this.dataGridViewTopicos.TabIndex = 4;
            this.dataGridViewTopicos.SelectionChanged += new System.EventHandler(this.DataGridViewTopicos_SelectionChanged);
            // 
            // topic
            // 
            this.topic.HeaderText = "topics";
            this.topic.Name = "topic";
            this.topic.ReadOnly = true;
            this.topic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            this.Variable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tarea
            // 
            this.tarea.HeaderText = "tarea";
            this.tarea.Name = "tarea";
            this.tarea.ReadOnly = true;
            this.tarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(650, 473);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(149, 40);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Cargar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelBotonesSeguridad
            // 
            this.panelBotonesSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotonesSeguridad.Controls.Add(this.buttonClienteCall);
            this.panelBotonesSeguridad.Controls.Add(this.buttonCertificadoCert);
            this.panelBotonesSeguridad.Controls.Add(this.buttonCertificadoCA);
            this.panelBotonesSeguridad.Location = new System.Drawing.Point(36, 12);
            this.panelBotonesSeguridad.Name = "panelBotonesSeguridad";
            this.panelBotonesSeguridad.Size = new System.Drawing.Size(767, 78);
            this.panelBotonesSeguridad.TabIndex = 10;
            // 
            // buttonClienteCall
            // 
            this.buttonClienteCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonClienteCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClienteCall.ForeColor = System.Drawing.Color.White;
            this.buttonClienteCall.Location = new System.Drawing.Point(614, 19);
            this.buttonClienteCall.Name = "buttonClienteCall";
            this.buttonClienteCall.Size = new System.Drawing.Size(149, 40);
            this.buttonClienteCall.TabIndex = 12;
            this.buttonClienteCall.Text = "Llave privada";
            this.buttonClienteCall.UseVisualStyleBackColor = false;
            this.buttonClienteCall.Click += new System.EventHandler(this.buttonLlavePrivada_Click);
            // 
            // buttonCertificadoCert
            // 
            this.buttonCertificadoCert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonCertificadoCert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCertificadoCert.ForeColor = System.Drawing.Color.White;
            this.buttonCertificadoCert.Location = new System.Drawing.Point(307, 19);
            this.buttonCertificadoCert.Name = "buttonCertificadoCert";
            this.buttonCertificadoCert.Size = new System.Drawing.Size(149, 40);
            this.buttonCertificadoCert.TabIndex = 11;
            this.buttonCertificadoCert.Text = "Certificado Cert";
            this.buttonCertificadoCert.UseVisualStyleBackColor = false;
            this.buttonCertificadoCert.Click += new System.EventHandler(this.buttonCertificadoCliente_Click);
            // 
            // buttonCertificadoCA
            // 
            this.buttonCertificadoCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonCertificadoCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCertificadoCA.ForeColor = System.Drawing.Color.White;
            this.buttonCertificadoCA.Location = new System.Drawing.Point(14, 19);
            this.buttonCertificadoCA.Name = "buttonCertificadoCA";
            this.buttonCertificadoCA.Size = new System.Drawing.Size(149, 40);
            this.buttonCertificadoCA.TabIndex = 10;
            this.buttonCertificadoCA.Text = "Certificado CA";
            this.buttonCertificadoCA.UseVisualStyleBackColor = false;
            this.buttonCertificadoCA.Click += new System.EventHandler(this.buttonCertificadoCA_Click);
            // 
            // panelTopic
            // 
            this.panelTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopic.Controls.Add(this.label1);
            this.panelTopic.Controls.Add(this.buttonGuardarTopic);
            this.panelTopic.Controls.Add(this.textBoxTopicoModifica);
            this.panelTopic.Location = new System.Drawing.Point(38, 168);
            this.panelTopic.Name = "panelTopic";
            this.panelTopic.Size = new System.Drawing.Size(765, 66);
            this.panelTopic.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Topic";
            // 
            // buttonGuardarTopic
            // 
            this.buttonGuardarTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonGuardarTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardarTopic.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarTopic.Location = new System.Drawing.Point(613, 14);
            this.buttonGuardarTopic.Name = "buttonGuardarTopic";
            this.buttonGuardarTopic.Size = new System.Drawing.Size(149, 40);
            this.buttonGuardarTopic.TabIndex = 10;
            this.buttonGuardarTopic.Text = "Modificar Topic";
            this.buttonGuardarTopic.UseVisualStyleBackColor = false;
            this.buttonGuardarTopic.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxTopicoModifica
            // 
            this.textBoxTopicoModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxTopicoModifica.Location = new System.Drawing.Point(103, 16);
            this.textBoxTopicoModifica.Name = "textBoxTopicoModifica";
            this.textBoxTopicoModifica.Size = new System.Drawing.Size(463, 30);
            this.textBoxTopicoModifica.TabIndex = 9;
            // 
            // panelCliente
            // 
            this.panelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCliente.Controls.Add(this.label2);
            this.panelCliente.Controls.Add(this.buttonModificarClientID);
            this.panelCliente.Controls.Add(this.textBoxClientID);
            this.panelCliente.Location = new System.Drawing.Point(38, 96);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(765, 66);
            this.panelCliente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client ID";
            // 
            // buttonModificarClientID
            // 
            this.buttonModificarClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(33)))), ((int)(((byte)(171)))));
            this.buttonModificarClientID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificarClientID.ForeColor = System.Drawing.Color.White;
            this.buttonModificarClientID.Location = new System.Drawing.Point(613, 14);
            this.buttonModificarClientID.Name = "buttonModificarClientID";
            this.buttonModificarClientID.Size = new System.Drawing.Size(149, 40);
            this.buttonModificarClientID.TabIndex = 10;
            this.buttonModificarClientID.Text = "Modificar Client ID";
            this.buttonModificarClientID.UseVisualStyleBackColor = false;
            this.buttonModificarClientID.Click += new System.EventHandler(this.buttonModificarClientID_Click);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(103, 19);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(463, 30);
            this.textBoxClientID.TabIndex = 9;
            // 
            // ConfiguracionAvanzada
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(835, 525);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelTopic);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewTopicos);
            this.Controls.Add(this.panelBotonesSeguridad);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(851, 564);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(851, 564);
            this.Name = "ConfiguracionAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionAvanzada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguracionAvanzada_FormClosing);
            this.Load += new System.EventHandler(this.ConfiguracionAvanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopicos)).EndInit();
            this.panelBotonesSeguridad.ResumeLayout(false);
            this.panelTopic.ResumeLayout(false);
            this.panelTopic.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTopicos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarea;
        private System.Windows.Forms.Panel panelBotonesSeguridad;
        private System.Windows.Forms.Button buttonClienteCall;
        private System.Windows.Forms.Button buttonCertificadoCert;
        private System.Windows.Forms.Button buttonCertificadoCA;
        private System.Windows.Forms.Panel panelTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarTopic;
        private System.Windows.Forms.TextBox textBoxTopicoModifica;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonModificarClientID;
        private System.Windows.Forms.TextBox textBoxClientID;
    }
}