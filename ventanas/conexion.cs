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
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");

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
                                mqttClient = new MqttClient(comboBoxIPCOM.Text);
                                mqttClient.Connect(comboBoxConexionBaudio.Text);
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
                                mqttClient = new MqttClient(comboBoxIPCOM.Text);
                                mqttClient.Connect(comboBoxConexionBaudio.Text,textBoxNameUser.Text,textBoxPass.Text);
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
            
           
            
            if (mqttClient.IsConnected && buttonConectar.Text == "Conectar")
            {   //imporante tener en cuenta el timer por que es lo que puede causar problemas mas adelante
                timer1.Enabled = true;
                //
                //VariablesControl.Temperatura1 = "conectado";
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
                {   //
                    timer1.Enabled = false;
                    //
                    //VariablesControl.Temperatura1 = "desconectado";
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
                {   //
                    timer1.Enabled= true;
                    //
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
                {   //
                    timer1.Enabled = false;
                    //
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
            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTemperatura1.Text = "T1 " + VariablesControl.Temperatura1;
            labelTemperatura2.Text = "T2 " + VariablesControl.Temperatura2;
            labelCorriente1.Text = "I1 " + VariablesControl.Corriente1;
            labelCorriente2.Text = "I2 " + VariablesControl.Corriente2;
            labelTiempo.Text = "time " + VariablesControl.Tiempo;
            try
            {
                if (mqttClient.IsConnected)
                {

                    string[] topic =
                    {
                    "test/datos/pwm1",
                    "test/datos/pwm2",
                    "test/datos/led1",
                    "test/datos/led2",
                    "test/datos/ventilador1",
                    "test/datos/ventilador2",
                };
                    mqttClient.Publish(topic[0], Encoding.UTF8.GetBytes(VariablesControl.Pwm1));
                    mqttClient.Publish(topic[1], Encoding.UTF8.GetBytes(VariablesControl.Pwm2));
                    mqttClient.Publish(topic[2], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed1));
                    mqttClient.Publish(topic[3], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed2));
                    mqttClient.Publish(topic[4], Encoding.UTF8.GetBytes(VariablesControl.Ventilador1));
                    mqttClient.Publish(topic[5], Encoding.UTF8.GetBytes(VariablesControl.Ventilador2));
                }

            }
            catch
            {

            }
           
            
        }
    }
 }

