using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using mqtt_serial.funciones;

namespace mqtt_serial.ventanas
{
    public partial class ConfiguracionAvanzada : Form
    {
        // Propiedades públicas para transferir los tópicos ordenados

        // Propiedades de seguridad y certificados
        public string RutaCertificadoCA { get; private set; }
        public string RutaCertificadoCliente { get; private set; }
        public string RutaClavePrivada { get; private set; }

        public ConfiguracionAvanzada()
        {
            InitializeComponent();
        }

        private void ConfiguracionAvanzada_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarGrid();
        }

        private void ConfigurarGrid()
        {
            dataGridViewTopicos.ReadOnly = true;
            dataGridViewTopicos.AllowUserToAddRows = false;
            dataGridViewTopicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTopicos.MultiSelect = false;

            dataGridViewTopicos.SelectionChanged += DataGridViewTopicos_SelectionChanged;
        }

        private void CargarGrid()
        {
            dataGridViewTopicos.Rows.Clear();

            // Cargar primero el bloque de recepción ("suscribe")
            foreach (string topic in VariablesControl.topicRecibir)
            {
                dataGridViewTopicos.Rows.Add(topic, ExtraerVariable(topic), "suscribe");
            }

            // Cargar a continuación el bloque de envío ("publish")
           foreach (string topic in VariablesControl.topicEnviar)
            {
                dataGridViewTopicos.Rows.Add(topic, ExtraerVariable(topic), "publish");
           }
        }

        private string ExtraerVariable(string topic)
        {
            if (string.IsNullOrWhiteSpace(topic)) return string.Empty;
            int lastSlash = topic.LastIndexOf('/');
            return lastSlash >= 0 ? topic.Substring(lastSlash + 1) : topic;
        }

        private void DataGridViewTopicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTopicos.SelectedRows.Count > 0)
            {
                var val = dataGridViewTopicos.SelectedRows[0].Cells[0].Value;
                textBoxTopicoModifica.Text = val != null ? val.ToString() : string.Empty;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTopicos.SelectedRows.Count == 0) return;

            string nuevoTopic = textBoxTopicoModifica.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoTopic))
            {
                MessageBox.Show("El topic no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = dataGridViewTopicos.SelectedRows[0].Index;
            dataGridViewTopicos.Rows[index].Cells[0].Value = nuevoTopic;
            dataGridViewTopicos.Rows[index].Cells[1].Value = ExtraerVariable(nuevoTopic);
        }

        // Selección de archivos de certificados y claves
        private void buttonCertificadoCA_Click(object sender, EventArgs e)
        {
            RutaCertificadoCA = SeleccionarArchivo("Certificado CA (*.crt;*.pem)|*.crt;*.pem");

            TextReader leer = new StreamReader(RutaCertificadoCA);
            MessageBox.Show($"CA: {leer.ReadToEnd()}");
            leer.Close();
           
        }

        private void buttonCertificadoCliente_Click(object sender, EventArgs e)
        {
            RutaCertificadoCliente = SeleccionarArchivo("Certificado Cliente (*.crt;*.cer;*.pem)|*.crt;*.cer;*.pem");
            
        }

        private void buttonLlavePrivada_Click(object sender, EventArgs e)
        {
            RutaClavePrivada = SeleccionarArchivo("Clave Privada (*.key;*.pem)|*.key;*.pem");
           
        }

        private string SeleccionarArchivo(string filtro)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Filter = filtro + "|Todos los archivos (*.*)|*.*";
                return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var filas = dataGridViewTopicos.Rows.Cast<DataGridViewRow>();

          //   Reconstruir arreglos manteniendo el orden visible de la grilla
            VariablesControl.topicRecibir = filas
                .Where(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == "suscribe")
                .Select(r => r.Cells[0].Value.ToString())
                  .ToArray();

            VariablesControl.topicEnviar = filas
                .Where(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == "publish")
                .Select(r => r.Cells[0].Value.ToString())
                .ToArray();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}