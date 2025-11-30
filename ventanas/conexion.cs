using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//librerias agregadas
using System.IO.Ports;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;


namespace mqtt_serial.ventanas
{
    public partial class conexion : Form
    {
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
            this.panel_user_pass.Visible = false;
            this.buttonrefrescar.Visible = false;

        }
        private void  ActualizarIP()
        {
            try
            {
                // Obtiene el nombre del host local
                string hostName = Dns.GetHostName();

                // Obtiene la información de la IP usando el nombre del host
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

                // Recorre la lista de direcciones para encontrar la IPv4
                foreach (IPAddress ip in hostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        // Muestra la dirección IP en el TextBox
                        comboBoxIPCOM.Text=ip.ToString();
                        
                        break; // Detiene el bucle una vez encontrada
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la dirección IP: " + ex.Message);
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

                this.buttonrefrescar.Visible = true;
                this.panel_conexion.Enabled = true;
                this.panel_ip_serial.Visible = true;

                switch (comboBoxTipoConexion.SelectedIndex)
                {
                    case (0)://opción de conexion local
                        this.panel_user_pass.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre PC";

                        break;
                    case (1)://opcion de conexion a servidor
                        this.panel_user_pass.Visible = true;
                        this.buttonrefrescar.Visible = false;
                        this.label_IP_COM.Text = "Dirección IP";
                        this.label_Conexion_Baudio.Text = "Nombre PC";
                        this.panel_conexion.Enabled = true;
                        break;
                    case (2)://opción de comunicacion serial
                        this.panel_user_pass.Visible = false;
                        this.buttonrefrescar.Visible = true;
                        this.label_IP_COM.Text = "Puerto";
                        this.label_Conexion_Baudio.Text = "Velocidad";
                        string[] puertos = SerialPort.GetPortNames();
                        this.comboBoxConexionBaudio.Items.AddRange(new object[] { "9600", "115200" });
                        this.comboBoxIPCOM.BeginUpdate();
                        for (int i = 0; i < puertos.Length; i++)
                        {
                            comboBoxIPCOM.Items.Add(puertos[i]);
                        }
                        this.comboBoxIPCOM.EndUpdate();
                        this.panel_conexion.Enabled = true;
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

        }
    }
 }

