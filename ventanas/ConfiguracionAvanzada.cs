using System;
using System.Windows.Forms;

namespace mqtt_serial.ventanas
{
    public partial class ConfiguracionAvanzada : Form
    {
        public string[] topicRecibir = {
            "test/sensor/temperatura1",
            "test/sensor/temperatura2",
            "test/sensor/corrienteQ1",
            "test/sensor/corrienteQ2",
            "test/sensor/tiempo"
        };

        public string[] topicEnviar = {
            "test/datos/pwm1",
            "test/datos/pwm2",
            "test/datos/led1",
            "test/datos/led2",
            "test/datos/ventilador1",
            "test/datos/ventilador2"
        };

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

            // Cargar tópicos a recibir respetando el orden del arreglo
            foreach (string topic in topicRecibir)
            {
                dataGridViewTopicos.Rows.Add(topic, ExtraerVariable(topic), "suscribe");
            }

            // Cargar tópicos a enviar a continuación
            foreach (string topic in topicEnviar)
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
                var cellValue = dataGridViewTopicos.SelectedRows[0].Cells[0].Value;
                if (cellValue != null)
                {
                    textBoxTopicoModifica.Text = cellValue.ToString();
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTopicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoTopic = textBoxTopicoModifica.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoTopic))
            {
                MessageBox.Show("El topic no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = dataGridViewTopicos.SelectedRows[0].Index;
            string nuevaVariable = ExtraerVariable(nuevoTopic);

            // Actualizar interfaz
            dataGridViewTopicos.Rows[index].Cells[0].Value = nuevoTopic;
            dataGridViewTopicos.Rows[index].Cells[1].Value = nuevaVariable;

            // Sincronizar cambio con los arreglos fuente según el índice global
            if (index < topicRecibir.Length)
            {
                topicRecibir[index] = nuevoTopic;
            }
            else
            {
                topicEnviar[index - topicRecibir.Length] = nuevoTopic;
            }
        }

        private void buttonCertificadoCA_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Seleccionar certificado CA";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Certificado CA (*.crt)|*.crt|Todos los archivos (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Lógica de guardado
        }
    }
}