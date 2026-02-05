using mqtt_serial.funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial.ventanas
{
    public partial class control_Q1 : Form
    {
        private ControlPID controlPID;
        private string kp;
        private string ki;
        private string kd;
        private string ts;
        private string setPoint;
        private string errorString;
        private double errorDouble;
        public control_Q1()
        {
            InitializeComponent();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)

        {
            //guardamos los datos que pasaron
            kp = comboBoxKp.Text;
            ki = comboBoxKi.Text;
            kd = comboBoxKd.Text;
            ts = comboBoxTs.Text;

            
            //impresion de prueba
            //labelKp.Text = comboBoxKp.Text;
            //labelKI.Text=comboBoxKi.Text;
            //labelKd.Text=comboBoxKd.Text;
            //labelTs.Text=comboBoxTs.Text;
            //example
            //string error ="hola";
            //controlPID = new ControlPID(error,this.comboBoxKp.Text,comboBoxTs.Text);
            //VariablesControl.Pwm1 = controlPID.PWM;

            //estos datos son para el timer
            

            
        }

        private void control_Q1_Load(object sender, EventArgs e)
        {
            comboBoxSetPoint.Text = "0";

            comboBoxKp.Text = "0";
            comboBoxKi.Text = "0";
            comboBoxKd.Text = "0";
            comboBoxTs.Text = "0";

            timer1.Enabled = true;

        }

        private void control_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                labelTemperature.Text = VariablesControl.Temperatura1;
                labelCurrent.Text= VariablesControl.Corriente1;
                
                setPoint = comboBoxSetPoint.Text;
                labelKI.Text =setPoint;
                errorDouble = double.Parse(setPoint) - (double.Parse(VariablesControl.Temperatura1)/100);
                errorString = errorDouble.ToString();
                labelKd.Text = errorString;

                if ((kp != null || kp != "0") && (ki == null || ki == "0") && (kd == null || kd == "0"))
                {
                    controlPID = new ControlPID(errorString, kp, ts);
                }
                else if ((kp != null || kp != "0") && (ki != null || ki != "0") && (kd == null || kd == "0"))
                {
                    controlPID = new ControlPID(errorString, kp, ki, ts);
                }
                else if ((kp != null || kp != "0") && (ki != null || ki != "0") && (kd != null || kd != "0"))
                {
                    controlPID = new ControlPID(errorString, kp, ki, kd, ts);
                }
                else
                {
                    controlPID = new ControlPID();
                }
                labelKp.Text = controlPID.PWM;
                VariablesControl.Pwm1=controlPID.PWM;
            }
            catch
            {
                //MessageBox.Show("no es un numero uno de los datos");
            }

        }

        private void buttonVentilador_Click(object sender, EventArgs e)
        {
            if (buttonVentilador.Text=="Encender")
            {
                pictureBoxVentilador.Image = Properties.Resources.ventilador_on;
                VariablesControl.Ventilador1 = "on";
                buttonVentilador.Text = "Apagar";
                buttonVentilador.BackColor = Color.FromArgb(227, 58, 24);
            }
            else
            {
                buttonVentilador.Text = "Encender";
                pictureBoxVentilador.Image = Properties.Resources.ventilador_off;
                VariablesControl.Ventilador1 = "off";
                buttonVentilador.BackColor = Color.FromArgb(44, 169, 94);

            }
        }
    }
}
