using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mqtt_serial.ventanas
{
    public partial class ConfiguracionAvanzada : Form
    {
        // Modelo de datos unificado
       public string[] topicRecibir ={
                    "test/sensor/temperatura1",
                    "test/sensor/temperatura2",
                    "test/sensor/corrienteQ1",
                    "test/sensor/corrienteQ2",
                    "test/sensor/tiempo"
            };
       public string[] topicEnviar ={
                    "test/datos/pwm1",
                    "test/datos/pwm2",
                    "test/datos/led1",
                    "test/datos/led2",
                    "test/datos/ventilador1",
                    "test/datos/ventilador2"
            };
        public class ConfiguracionTopic
        {
            public string Topic { get; set; }
            public string Variable { get; set; }
            public string Tarea { get; set; }

            public ConfiguracionTopic(string topic, string variable, string tarea)
            {
                Topic = topic;
                Variable = variable;
                Tarea = tarea;
            }
        }

        private List<ConfiguracionTopic> listaTopics;

        public ConfiguracionAvanzada()
        {
            InitializeComponent();
        }

        private void ConfiguracionAvanzada_Load(object sender, EventArgs e)
        {
            InicializarDatos(topicRecibir, topicEnviar);
            ConfigurarGrid();
            CargarGrid();
        }

        private void InicializarDatos(string[] topicRecibir, string[] topicEnviar)
        {
            listaTopics = new List<ConfiguracionTopic>
            {
                new ConfiguracionTopic(topicRecibir[0], "temperatura1", "suscribe"),
                new ConfiguracionTopic(topicRecibir[1], "temperatura2", "suscribe"),
                new ConfiguracionTopic(topicRecibir[2], "corrienteQ1", "suscribe"),
                new ConfiguracionTopic(topicRecibir[3], "corrienteQ2", "suscribe"),
                new ConfiguracionTopic(topicRecibir[4], "tiempo", "suscribe"),
                new ConfiguracionTopic(topicEnviar[0], "pwm1", "publish"),
                new ConfiguracionTopic(topicEnviar[1], "pwm2", "publish"),
                new ConfiguracionTopic(topicEnviar[2], "led1", "publish"),
                new ConfiguracionTopic(topicEnviar[3], "led2", "publish"),
                new ConfiguracionTopic(topicEnviar[4], "ventilador1", "publish"),
                new ConfiguracionTopic(topicEnviar[5], "ventilador2", "publish")
            };
        }

        private void ConfigurarGrid()
        {
            // Bloquear edición directa en las celdas del DataGridView
            dataGridViewTopicos.ReadOnly = true;
            dataGridViewTopicos.AllowUserToAddRows = false;
            dataGridViewTopicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTopicos.MultiSelect = false;

            // Vincular evento de selección
            dataGridViewTopicos.SelectionChanged += DataGridViewTopicos_SelectionChanged;
        }

        private void CargarGrid()
        {
            dataGridViewTopicos.Rows.Clear();
            foreach (var item in listaTopics)
            {
                dataGridViewTopicos.Rows.Add(item.Topic, item.Variable, item.Tarea);
            }
        }

        private void DataGridViewTopicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTopicos.SelectedRows.Count > 0)
            {
                var row = dataGridViewTopicos.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    // Asumiendo que el TextBox de la interfaz se llama textBoxTopic
                    textBoxTopicoModifica.Text = row.Cells[0].Value.ToString();
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

            // Actualizar la lista en memoria y la celda visible
            listaTopics[index].Topic = nuevoTopic;
            dataGridViewTopicos.Rows[index].Cells[0].Value = nuevoTopic;
        }

        private void buttonCertificadoCA_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Seleccionar certificado CA";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Certificado CA (*.crt)|*.crt|Todos los archivos (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

    }
}