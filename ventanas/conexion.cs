using DocumentFormat.OpenXml.Drawing.Diagrams;
using mqtt_serial.funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;

//librerias agregadas
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//librerias mqtt
//using System.Net;
using System.Net.Security;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;
using System.Windows.Media.Animation;



namespace mqtt_serial.ventanas
{
    public partial class Conexion : Form
    {
        //variables a manejar
        public MqttClient mqttClient;

        public string ObtenerIPLocal()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                var ip = host.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
                return ip?.ToString() ?? "127.0.0.1";
            }
            catch (Exception ex)
            {
                return $"Error IP: {ex.Message}";
            }
        }



        //seguridad de conexion
        X509Certificate cacert = null;
        X509Certificate clientsert = null;
        X509Certificate certcallback = null;
        bool seguridad = false;
        ConfiguracionAvanzada configurar = new ConfiguracionAvanzada();

        public Conexion()
        {
            InitializeComponent();

        }

        private void habilitarherramientas(bool habilitar)
        {
            comboBoxConexionBaudio.Enabled = habilitar;
            comboBoxIPCOM.Enabled = habilitar;
            comboBoxTipoConexion.Enabled = habilitar;
            textBoxNameUser.Enabled = habilitar;
            textBoxPass.Enabled = habilitar;
            buttonRefrescar.Enabled = habilitar;

        }


        //parametros que se reciben del mqtt
        private void MqClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                string topic = e.Topic;
                string message = Encoding.UTF8.GetString(e.Message);
                int index = Array.IndexOf(VariablesControl.topicRecibir, topic);
                switch (index)
                {
                    case 0: VariablesControl.Temperatura1 = message; break;
                    case 1: VariablesControl.Temperatura2 = message; break;
                    case 2: VariablesControl.Corriente1 = message; break;
                    case 3: VariablesControl.Corriente2 = message; break;
                    case 4: VariablesControl.Tiempo = message; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir mensaje MQTT: " + ex.Message);
            }

        }


        private void comboBoxTipoConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxConexionBaudio.Items.Clear();
                this.comboBoxConexionBaudio.Text = "";

                this.comboBoxIPCOM.Items.Clear();
                this.comboBoxIPCOM.Text = "";

                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case (0)://opción de conexion local
                        this.buttonRefrescar.Text = "Avanzado";
                        this.panelUserPass.Visible = true;

                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Puerto";
                        this.comboBoxIPCOM.Items.Add(ObtenerIPLocal());
                        this.comboBoxIPCOM.SelectedIndex = 0;
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "1883", "1884", "8883" });
                        this.comboBoxConexionBaudio.SelectedIndex = 0;

                        break;
                    case (1):
                        this.buttonRefrescar.Text = "Refrescar";
                        this.panelUserPass.Visible = false;

                        this.label_IP_COM.Text = "Puerto";
                        this.label_Conexion_Baudio.Text = "Velocidad";
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "9600", "19200", "38400", "115200" });
                        this.comboBoxConexionBaudio.SelectedIndex = 0;

                        string[] puertos = SerialPort.GetPortNames();
                        if (puertos.Length == 0)
                        {
                            MessageBox.Show("no hay puertos conectados");
                        }
                        else
                        {
                            this.comboBoxIPCOM.Items.AddRange(puertos);
                            this.comboBoxIPCOM.SelectedIndex = 0;
                        }
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        private void buttonrefrescar_Click(object sender, EventArgs e)
        {
            try
            {

                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case 0:

                        this.configurar.ShowDialog();

                        break;
                    case 1:
                        this.comboBoxIPCOM.Items.Clear();
                        this.comboBoxIPCOM.Text = "";

                        string[] puertosActualizados = SerialPort.GetPortNames();

                        comboBoxIPCOM.Items.AddRange(puertosActualizados);
                        if (comboBoxIPCOM.Items.Count > 0)
                        {
                            comboBoxIPCOM.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("no hay puertos conectados");
                        }
                        break;

                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (comboBoxIPCOM.Text == "")
                            {
                                MessageBox.Show("este campo no puede estar vacio\nfavor colocar una dirección IP");
                            }
                            else if (comboBoxConexionBaudio.Text == "")
                            {
                                MessageBox.Show("este campo no puede estar vacio\nfavor colocar un puerto de conexión");
                            }
                            else
                            {
                                conexionMqtt();
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                        break;

                    case 1:

                        conexionSerial();

                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void conexionMqtt()
        {
            try
            {
                if (seguridad == true && cacert != null && clientsert != null && certcallback != null)
                {
                    mqttClient = new MqttClient(comboBoxIPCOM.Text, int.Parse(comboBoxConexionBaudio.Text), seguridad, cacert, clientsert, MqttSslProtocols.TLSv1_2);
                }
                else
                {
                    mqttClient = new MqttClient(comboBoxIPCOM.Text, int.Parse(comboBoxConexionBaudio.Text), false, null, null, MqttSslProtocols.None);
                }
                mqttClient.Connect(VariablesControl.ClienteId, textBoxNameUser.Text, textBoxPass.Text);


                if (mqttClient != null && mqttClient.IsConnected && buttonConectar.Text == "Conectar")
                {
                    timer1.Enabled = true;
                    VariablesControl.EstadoDeConexion = true;
                    comboBoxTipoConexion.Enabled = false;

                    buttonConectar.Text = "Desconectar";
                    buttonConectar.BackColor = Color.FromArgb(227, 58, 24);

                    mqttClient.MqttMsgPublishReceived += MqClient_MqttMsgPublishReceived;
                    habilitarherramientas(false);

                    foreach (string topic in VariablesControl.topicRecibir)
                    {
                        mqttClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    }

                }
                else //if (buttonConectar.Text == "Desconectar")
                {
                    if (mqttClient != null && mqttClient.IsConnected)
                    {

                        timer1.Enabled = false;
                        //
                        desconectar();

                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error en: {error}");
            }
        }

        private void conexionSerial()
        {
            if (buttonConectar.Text == "Conectar" || VariablesControl.EstadoDeConexion == false)
            {


                serialPort1.PortName = comboBoxIPCOM.Text;
                serialPort1.BaudRate = int.Parse(comboBoxConexionBaudio.Text);


                serialPort1.Open();

                if (serialPort1.IsOpen)
                {   //
                    habilitarherramientas(false);
                    timer1.Enabled = true;
                    VariablesControl.EstadoDeConexion = true;
                    //
                    comboBoxTipoConexion.Enabled = false;
                    buttonConectar.Text = "Desconectar";
                    buttonConectar.BackColor = Color.FromArgb(227, 58, 24);
                }
                else
                {
                    MessageBox.Show("no se logro la conexión");
                }

            }
            else if (VariablesControl.EstadoDeConexion == true)
            {
                if (serialPort1.IsOpen)
                {
                    desconectar();
                    timer1.Enabled = false;
                    buttonConectar.Text = "Conectar";
                }

            }


        }

        private void conexion_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                desconectar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            //MessageBox.Show("se esta cerrando");
        }

        private void publicar()
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {

                mqttClient.Publish(VariablesControl.topicEnviar[0], Encoding.UTF8.GetBytes(VariablesControl.Pwm1));
                mqttClient.Publish(VariablesControl.topicEnviar[1], Encoding.UTF8.GetBytes(VariablesControl.Pwm2));
                mqttClient.Publish(VariablesControl.topicEnviar[2], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed1));
                mqttClient.Publish(VariablesControl.topicEnviar[3], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed2));
                mqttClient.Publish(VariablesControl.topicEnviar[4], Encoding.UTF8.GetBytes(VariablesControl.Ventilador1));
                mqttClient.Publish(VariablesControl.topicEnviar[5], Encoding.UTF8.GetBytes(VariablesControl.Ventilador2));
            }
            else if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine($"$PWM1{VariablesControl.Pwm1}");
                System.Threading.Thread.Sleep(10);
                serialPort1.WriteLine($"$PWM2{VariablesControl.Pwm2}");
                System.Threading.Thread.Sleep(10);
                serialPort1.WriteLine($"$LED1{VariablesControl.AlarmaLed1}");
                System.Threading.Thread.Sleep(10);
                serialPort1.WriteLine($"$LED2{VariablesControl.AlarmaLed2}");
                System.Threading.Thread.Sleep(10);
                serialPort1.WriteLine($"$VENT1{VariablesControl.Ventilador1}");
                System.Threading.Thread.Sleep(10);
                serialPort1.WriteLine($"$VENT2{VariablesControl.Ventilador2}");
                System.Threading.Thread.Sleep(10);
            }
        }

        private void conexion_Load(object sender, EventArgs e)
        {
            comboBoxTipoConexion.SelectedIndex = 0;
            comboBoxConexionBaudio.SelectedIndex = 0;
        }
        public void desconectar()
        {
            try
            {
                timer1.Enabled = false;
                habilitarherramientas(true);

                if (mqttClient != null && mqttClient.IsConnected)
                {
                    VariablesControl.reseteoParametros();
                    publicar();
                    System.Threading.Thread.Sleep(1000);

                    mqttClient.Disconnect();
                    mqttClient = null;
                    VariablesControl.EstadoDeConexion = false;
                    comboBoxTipoConexion.Enabled = true;
                    buttonConectar.Text = "Conectar";
                    buttonConectar.BackColor = Color.FromArgb(44, 169, 94);

                }
                else if (serialPort1.IsOpen)
                {
                    VariablesControl.reseteoParametros();
                    publicar();
                    System.Threading.Thread.Sleep(1000);

                    serialPort1.Close();
                    VariablesControl.EstadoDeConexion = false;
                    comboBoxTipoConexion.Enabled = true;
                    buttonConectar.Text = "Conectar";
                    buttonConectar.BackColor = Color.FromArgb(44, 169, 94);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient != null && mqttClient.IsConnected || serialPort1.IsOpen)
                {
                    publicar();
                }

                if (!VariablesControl.EstadoDeConexion)
                {
                    if (mqttClient != null && mqttClient.IsConnected)
                    {
                        conexionMqtt();
                    }
                    if (serialPort1.IsOpen)
                    {
                        conexionSerial();
                    }
                }

            }
            catch
            {
                MessageBox.Show("hubo un error");
            }


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                {
                    string SerialData = serialPort1.ReadLine();
                    if (SerialData.IndexOf("#Temp1") != -1)
                    {
                        VariablesControl.Temperatura1 = SerialData.Substring(6);
                    }
                    else if (SerialData.IndexOf("#Temp2") != -1)
                    {
                        VariablesControl.Temperatura2 = SerialData.Substring(6);
                    }
                    else if (SerialData.IndexOf("#Corri1") != -1)
                    {
                        VariablesControl.Corriente1 = SerialData.Substring(7);
                    }
                    else if (SerialData.IndexOf("#Corri2") != -1)
                    {
                        VariablesControl.Corriente2 = SerialData.Substring(7);
                    }
                    else if (SerialData.IndexOf("#Tiempo") != -1)
                    {
                        VariablesControl.Tiempo = SerialData.Substring(7);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

