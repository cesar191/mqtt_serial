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
//librerias mqtt
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace mqtt_serial.ventanas
{
    public partial class conexion : Form
    {
        //variables a manejar
        public MqttClient mqttClient;

        //private string temperatura1;
        //private string temperatura2;
        //private string corriente1;
        //private string corriente2;
        //private string tiempo;

        //public string Temperatura1 { get {return temperatura1; } set {temperatura1 = value;}}
        //public string Temperatura2 { get {return temperatura2; } set {temperatura2 = value;}}
        //public string Corriente1 { get { return corriente1; } set {corriente1 = value; } }
        //public string Corriente2 { get {return corriente2; } set {corriente2 = value; } }
        //public string Tiempo { get { return tiempo; } set { tiempo = value; }  }


        public conexion()
        {
            InitializeComponent();
            visibleoption();
            comboBoxTipoConexion.SelectedIndex = 0;
        }
        private void visibleoption()
        {
            this.panel_ip_serial.Visible = false;
            this.panel_conexion.Enabled = false;
            this.panelUserPass.Visible = false;
            this.buttonRefrescar.Visible = false;

        }
        public string ObtenerIPLocal()
        {
            try
            {
                // 1. Obtiene el nombre del host local
                string hostName = Dns.GetHostName();

                // 2. Obtiene toda la información de IP asociada al host
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

                // 3. Usa LINQ para encontrar la primera dirección IPv4
                IPAddress ipv4Address = hostEntry.AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

                // 4. Devuelve la dirección IP si se encontró
                if (ipv4Address != null)
                {
                    return ipv4Address.ToString();
                }

                // Si no se encuentra una IPv4 (caso raro, pero posible)
                return "ERROR: No se encontró una dirección IPv4 válida.";
            }
            catch (Exception ex)
            {
                // En caso de error de red o DNS, devuelve el mensaje de la excepción
                return $"ERROR al obtener IP: {ex.Message}";
            }
        }


        //parametros que se reciben del mqtt
        private void MqClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string message = Encoding.UTF8.GetString(e.Message);
            if (topic == "test/sensor/temperatura1")
            {
                VariablesControl.Temperatura1 = message;
            }
            else if (topic == "test/sensor/temperatura2")
            {
                VariablesControl.Temperatura2 = message;
            }
            else if (topic == "test/sensor/corrienteQ1")
            {
                VariablesControl.Corriente1 = message;
            }
            else if (topic == "test/sensor/corrienteQ2")
            {
                VariablesControl.Corriente2 = message;
            }
            else if (topic == "test/sensor/tiempo")
            {
                VariablesControl.Tiempo = message;
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

                this.buttonRefrescar.Visible = true;
                this.panel_conexion.Enabled = true;
                this.panel_ip_serial.Visible = true;

                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case (0)://opción de conexion local
                        this.panelUserPass.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre PC";
                        this.comboBoxIPCOM.Items.Add(ObtenerIPLocal());
                        this.comboBoxIPCOM.SelectedIndex = 0;
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "Laptop1", "ControlPC" });
                        this.comboBoxConexionBaudio.SelectedIndex = 0;

                        break;
                    case (1)://opcion de conexion a servidor
                        this.panelUserPass.Visible = true;
                        this.buttonRefrescar.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre PC";
                        this.panel_conexion.Enabled = true;
                        this.comboBoxIPCOM.Items.Add(ObtenerIPLocal());
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "Laptop1", "ControlPC" });

                        break;
                    case (2)://opción de comunicacion serial
                        //datos para la comunicación

                        this.panelUserPass.Visible = false;
                        this.buttonRefrescar.Visible = true;
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
            this.comboBoxIPCOM.Items.Clear();
            this.comboBoxIPCOM.Text = "";
            switch (comboBoxTipoConexion.SelectedIndex)
            {
                case 0:
                    string ipActualizada = ObtenerIPLocal();
                    comboBoxIPCOM.Items.Add(ipActualizada);
                    break;
                case 2:
                    string[] puertosActualizados= SerialPort.GetPortNames();
                    comboBoxIPCOM.Items.AddRange(puertosActualizados);
                    break;

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
                            if (comboBoxIPCOM.Text=="")
                            {
                                MessageBox.Show("este campo no puede estar vacio\nfavor colocar una dirección ip");
                            }
                            else if (comboBoxConexionBaudio.Text=="")
                            {
                                MessageBox.Show("este campo no puede estar vacio\nfavor colocar un nombre de dispositivo");
                            }
                            else
                            {
                                conexionMqtt();
                            }
                        }
                        catch (Exception error) {
                           MessageBox.Show(error.Message);  
                        }
                        
                        
                        break;
                    case 1:
                        try
                        {
                            if (comboBoxIPCOM.Text == "")
                            {
                                MessageBox.Show("Este campo no puede estar vacio\nfavor colocar una dirección ip");
                            }
                            else if (comboBoxConexionBaudio.Text == "")
                            {
                                MessageBox.Show("Este campo no puede estar vacio\nfavor colocar un nombre de dispositivo");
                            }
                            else if (textBoxNameUser.Text=="")
                            {
                                MessageBox.Show("Favor colocar un nombre de usuario");
                            }else if (textBoxPass.Text=="")
                            {
                                MessageBox.Show("Favor colocar la contraseña del usuario");
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
                    case 2:
                        conexionSerial();      
                        break;
                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }
        private void conexionMqtt(){
            mqttClient = new MqttClient(comboBoxIPCOM.Text);
           
            mqttClient.Connect(comboBoxConexionBaudio.Text);
            if (mqttClient.IsConnected && buttonConectar.Text == "Conectar")
            {
                VariablesControl.Temperatura1 = "conectado";
                comboBoxTipoConexion.Enabled = false;
                buttonConectar.Text = "Desconectar";
                buttonConectar.BackColor = Color.FromArgb(227, 58, 24);
                mqttClient.MqttMsgPublishReceived += MqClient_MqttMsgPublishReceived;
                string[] topics = new string[5];
                topics[0] = "test/sensor/temperatura1";
                topics[1] = "test/sensor/temperatura2";
                topics[2] = "test/sensor/corrienteQ1";
                topics[3] = "test/sensor/corrienteQ2";
                topics[4] = "test/sensor/tiempo";
                byte[] msg = new byte[5];
                msg[0] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                msg[1] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                msg[2] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                msg[3] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                msg[4] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;

                mqttClient.Subscribe(topics, msg);
            }
            else //if (buttonConectar.Text == "Desconectar")
            {
                if (mqttClient.IsConnected)
                {
                    VariablesControl.Temperatura1 = "desconectado";
                    mqttClient.Disconnect();
                    mqttClient = null;
                }
                comboBoxTipoConexion.Enabled = true;
                buttonConectar.Text = "Conectar";
                buttonConectar.BackColor = Color.FromArgb(44, 169, 94);
                
            }
        }
        
        private void conexionSerial()
        {
            if (buttonConectar.Text=="Conectar")
            {
                serialPort1.PortName = comboBoxIPCOM.Text;
                serialPort1.BaudRate = int.Parse(comboBoxConexionBaudio.Text);
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    comboBoxTipoConexion.Enabled = false;
                    buttonConectar.Text = "Desconectar";
                    buttonConectar.BackColor = Color.FromArgb(227, 58, 24);
                    MessageBox.Show("conexion serial exitosa");
                }
                else
                {
                    MessageBox.Show("no se logro la conexión");
                }
                
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    buttonConectar.Text = "Conectar";
                }
               
                comboBoxTipoConexion.Enabled = true;
                buttonConectar.BackColor = Color.FromArgb(44, 169, 94);

            }

            
        }

        private void conexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

            try
            {
                if (mqttClient != null)
                {
                    if (mqttClient.IsConnected) { 
                        mqttClient.Disconnect();
                    }
                }
                else if(serialPort1.IsOpen)
                {
                    serialPort1.Close ();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void conexion_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTemperatura1.Text = "T1 " + VariablesControl.Temperatura1;
            labelTemperatura2.Text = "T2 " + VariablesControl.Temperatura2;
            labelCorriente1.Text = "I1 " + VariablesControl.Corriente1;
            labelCorriente2.Text = "I2 " + VariablesControl.Corriente2;
            labelTiempo.Text = "time " + VariablesControl.Tiempo;
        }
    }
 }

