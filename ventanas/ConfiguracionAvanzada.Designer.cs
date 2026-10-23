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
            this.buttonCertificadoCA = new System.Windows.Forms.Button();
            this.buttonCertificadoCert = new System.Windows.Forms.Button();
            this.buttonClienteCall = new System.Windows.Forms.Button();
            this.buttonSeguridad = new System.Windows.Forms.Button();
            this.dataGridViewTopicos = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTopicoModifica = new System.Windows.Forms.TextBox();
            this.buttonGuardarTopic = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopicos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCertificadoCA
            // 
            this.buttonCertificadoCA.Location = new System.Drawing.Point(32, 39);
            this.buttonCertificadoCA.Name = "buttonCertificadoCA";
            this.buttonCertificadoCA.Size = new System.Drawing.Size(149, 40);
            this.buttonCertificadoCA.TabIndex = 0;
            this.buttonCertificadoCA.Text = "Certificado CA";
            this.buttonCertificadoCA.UseVisualStyleBackColor = true;
            this.buttonCertificadoCA.Click += new System.EventHandler(this.buttonCertificadoCA_Click);
            // 
            // buttonCertificadoCert
            // 
            this.buttonCertificadoCert.Location = new System.Drawing.Point(238, 39);
            this.buttonCertificadoCert.Name = "buttonCertificadoCert";
            this.buttonCertificadoCert.Size = new System.Drawing.Size(149, 40);
            this.buttonCertificadoCert.TabIndex = 1;
            this.buttonCertificadoCert.Text = "Certificado Cert";
            this.buttonCertificadoCert.UseVisualStyleBackColor = true;
            // 
            // buttonClienteCall
            // 
            this.buttonClienteCall.Location = new System.Drawing.Point(449, 39);
            this.buttonClienteCall.Name = "buttonClienteCall";
            this.buttonClienteCall.Size = new System.Drawing.Size(149, 40);
            this.buttonClienteCall.TabIndex = 2;
            this.buttonClienteCall.Text = "Llave privada";
            this.buttonClienteCall.UseVisualStyleBackColor = true;
            // 
            // buttonSeguridad
            // 
            this.buttonSeguridad.Location = new System.Drawing.Point(653, 39);
            this.buttonSeguridad.Name = "buttonSeguridad";
            this.buttonSeguridad.Size = new System.Drawing.Size(149, 40);
            this.buttonSeguridad.TabIndex = 3;
            this.buttonSeguridad.Text = "Cifrado";
            this.buttonSeguridad.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTopicos
            // 
            this.dataGridViewTopicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTopicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.Variable,
            this.tarea});
            this.dataGridViewTopicos.Location = new System.Drawing.Point(32, 211);
            this.dataGridViewTopicos.MultiSelect = false;
            this.dataGridViewTopicos.Name = "dataGridViewTopicos";
            this.dataGridViewTopicos.Size = new System.Drawing.Size(770, 226);
            this.dataGridViewTopicos.TabIndex = 4;
            this.dataGridViewTopicos.SelectionChanged += new System.EventHandler(this.DataGridViewTopicos_SelectionChanged);
            // 
            // topic
            // 
            this.topic.HeaderText = "topics";
            this.topic.Name = "topic";
            this.topic.ReadOnly = true;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // tarea
            // 
            this.tarea.HeaderText = "tarea";
            this.tarea.Name = "tarea";
            this.tarea.ReadOnly = true;
            // 
            // textBoxTopicoModifica
            // 
            this.textBoxTopicoModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxTopicoModifica.Location = new System.Drawing.Point(135, 121);
            this.textBoxTopicoModifica.Name = "textBoxTopicoModifica";
            this.textBoxTopicoModifica.Size = new System.Drawing.Size(463, 30);
            this.textBoxTopicoModifica.TabIndex = 5;
            // 
            // buttonGuardarTopic
            // 
            this.buttonGuardarTopic.Location = new System.Drawing.Point(653, 119);
            this.buttonGuardarTopic.Name = "buttonGuardarTopic";
            this.buttonGuardarTopic.Size = new System.Drawing.Size(149, 40);
            this.buttonGuardarTopic.TabIndex = 6;
            this.buttonGuardarTopic.Text = "Modificar";
            this.buttonGuardarTopic.UseVisualStyleBackColor = true;
            this.buttonGuardarTopic.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(616, 462);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(149, 40);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Cargar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Topic";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConfiguracionAvanzada
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(835, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonGuardarTopic);
            this.Controls.Add(this.textBoxTopicoModifica);
            this.Controls.Add(this.dataGridViewTopicos);
            this.Controls.Add(this.buttonSeguridad);
            this.Controls.Add(this.buttonClienteCall);
            this.Controls.Add(this.buttonCertificadoCert);
            this.Controls.Add(this.buttonCertificadoCA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(851, 564);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(851, 564);
            this.Name = "ConfiguracionAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionAvanzada";
            this.Load += new System.EventHandler(this.ConfiguracionAvanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCertificadoCA;
        private System.Windows.Forms.Button buttonCertificadoCert;
        private System.Windows.Forms.Button buttonClienteCall;
        private System.Windows.Forms.Button buttonSeguridad;
        private System.Windows.Forms.DataGridView dataGridViewTopicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarea;
        private System.Windows.Forms.TextBox textBoxTopicoModifica;
        private System.Windows.Forms.Button buttonGuardarTopic;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}