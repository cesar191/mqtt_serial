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
//librerias mqtt
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace mqtt_serial.ventanas
{
    public partial class conexion : Form
    {
        //variables a manejar
        public MqttClient mqttClient;
        string[] topicRecibir ={
                    "test/sensor/temperatura1",
                    "test/sensor/temperatura2",
                    "test/sensor/corrienteQ1",
                    "test/sensor/corrienteQ2",
                    "test/sensor/tiempo"
            };
        string[] topicEnviar ={
                    "test/datos/pwm1",
                    "test/datos/pwm2",
                    "test/datos/led1",
                    "test/datos/led2",
                    "test/datos/ventilador1",
                    "test/datos/ventilador2"
            };
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

        public conexion()
        {
            InitializeComponent();
            
        }
        private void visibleoption()
        {
            this.panel_ip_serial.Visible = false;
            this.panel_conexion.Enabled = false;
            this.panelUserPass.Visible = false;
            this.buttonRefrescar.Visible = false;

        }
        
        //parametros que se reciben del mqtt
        private void MqClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try {
                string topic = e.Topic;
                string message = Encoding.UTF8.GetString(e.Message);
                int index = Array.IndexOf(topicRecibir, topic);
                switch (index)
                {
                    case 0: VariablesControl.Temperatura1 = message; break;
                    case 1: VariablesControl.Temperatura2 = message; break;
                    case 2: VariablesControl.Corriente1 = message; break;
                    case 3: VariablesControl.Corriente2 = message; break;
                    case 4: VariablesControl.Tiempo = message; break;
                }
            }
            catch(Exception ex){
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

                this.buttonRefrescar.Visible = true;
                this.panel_conexion.Enabled = true;
                this.panel_ip_serial.Visible = true;

                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case (0)://opción de conexion local
                        this.panelUserPass.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre Cliente";
                        this.comboBoxIPCOM.Items.Add(ObtenerIPLocal());
                        this.comboBoxIPCOM.SelectedIndex = 0;
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "Laptop1", "ControlPC" });
                        this.comboBoxConexionBaudio.SelectedIndex = 0;

                        break;
                    case (1)://opcion de conexion a servidor
                        this.panelUserPass.Visible = true;
                        this.buttonRefrescar.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre Cliente";
                        this.panel_conexion.Enabled = true;
                        this.comboBoxIPCOM.Items.Add(ObtenerIPLocal());
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "Laptop1", "ControlPC" });

                        break;
                    case (2):
                    //case (2)://opción de comunicación serial
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
                    string[] puertosActualizados = SerialPort.GetPortNames();
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
            
            if (mqttClient != null && mqttClient.IsConnected && buttonConectar.Text == "Conectar")
            {   //importante tener en cuenta el timer por que es lo que puede causar problemas mas adelante
                timer1.Enabled = true;
                VariablesControl.EstadoDeConexion = true;
                //
                //VariablesControl.Temperatura1 = "conectado";
                comboBoxTipoConexion.Enabled = false;
                buttonConectar.Text = "Desconectar";
                buttonConectar.BackColor = Color.FromArgb(227, 58, 24);
                mqttClient.MqttMsgPublishReceived += MqClient_MqttMsgPublishReceived;

                
                 foreach (string topic in topicRecibir)
                 {
                    mqttClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                 }
            }
            else //if (buttonConectar.Text == "Desconectar")
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {   //
                    timer1.Enabled = false;
                    //
                    desconectar();
                    
                }
                            
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
                    VariablesControl.EstadoDeConexion = true;
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
                { 
                    //
                    desconectar();

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
        private void publicar() {
            if(mqttClient != null && mqttClient.IsConnected)
            {

                mqttClient.Publish(topicEnviar[0], Encoding.UTF8.GetBytes(VariablesControl.Pwm1));
                mqttClient.Publish(topicEnviar[1], Encoding.UTF8.GetBytes(VariablesControl.Pwm2));
                mqttClient.Publish(topicEnviar[2], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed1));
                mqttClient.Publish(topicEnviar[3], Encoding.UTF8.GetBytes(VariablesControl.AlarmaLed2));
                mqttClient.Publish(topicEnviar[4], Encoding.UTF8.GetBytes(VariablesControl.Ventilador1));
                mqttClient.Publish(topicEnviar[5], Encoding.UTF8.GetBytes(VariablesControl.Ventilador2));
            }
        }

        private void conexion_Load(object sender, EventArgs e)
        {
            visibleoption();
            comboBoxTipoConexion.SelectedIndex = 0;
        }
        public void desconectar()
        {
            try
            {
                timer1.Enabled = false;
               
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
                if (mqttClient !=null && mqttClient.IsConnected)
                {
                        publicar();
                    
        
                }else if (serialPort1.IsOpen)
                {

                }
                if(!VariablesControl.EstadoDeConexion)
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

       
    }
 }

