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
        #region VariablesDeControl
        private ControlPID controlPID=new ControlPID();
        
        private double kp=0;
        private double ki=0;
        private double kd = 0;
        private double ts = 0;
        private double setPoint = 0;
        private string errorString;
        private double errorDouble = 0;
        #endregion

        private double temperatura1;
        //private string temperatura2;
        private double corriente1;
        private double tiempo;
        private double pwm;

        private void SystemControl( double errorDouble, double kp,double ki, double kd, double ts)
        {
            if (kp != 0 && ki == 0 && kd == 0)
            {
                this.controlPID.SystemControlP(errorDouble, kp);
            }
            else if (kp != 0 && ki != 0 && kd == 0)
            {
                this.controlPID.SystemControlPI(errorDouble, kp, ki, ts);
            }
            else if (kp != 0 && ki != 0 && kd != 0)
            {
                this.controlPID.SystemControlPID(errorDouble, kp, ki, kd, ts);
            }
            else
            {

            }

            VariablesControl.Pwm1 = controlPID.PWM.ToString();
        }

        public control_Q1()
        {
            InitializeComponent();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)

        {

            double.TryParse(comboBoxKp.Text, out kp);
            double.TryParse(comboBoxKi.Text, out ki);
            double.TryParse(comboBoxKd.Text, out kd);
            double.TryParse(comboBoxTs.Text, out ts);

            for (int i=0;i<controlPID.ErrorArray.Length; i++)
            {
                controlPID.ErrorArray[i] = 0;
            }
            for (int i=0;i<controlPID.PwmArray.Length;i++)
            {
                controlPID.PwmArray[i] = 0;
            }
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
                labelTemperature.Text = VariablesControl.Temperatura1+ " °C";
                labelCurrent.Text= VariablesControl.Corriente1+" A";
                
                double.TryParse(comboBoxSetPoint.Text,out setPoint);  
                
                errorDouble = setPoint - (double.Parse(VariablesControl.Temperatura1)/100);
                errorString = errorDouble.ToString();
                SystemControl(errorDouble,kp,ki,kd,ts);
                //para graficar
                pwm = controlPID.PWM;
                temperatura1 = double.Parse(VariablesControl.Temperatura1) / 100;
                corriente1 = double.Parse(VariablesControl.Corriente1) / 100;
                tiempo = double.Parse(VariablesControl.Tiempo);
                //
                if (tiempo > 10)
                {
                    if (tiempo > 300)
                    {
                        this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo - 300;
                        this.chargraficaQ1.ChartAreas[1].AxisX.Minimum = tiempo - 300;
                        //this.chargraficaQ1.ChartAreas[0].AxisX.Maximum = tiempo;
                    }
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, pwm)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, corriente1)));
                }
                else
                {
                    this.chargraficaQ1.Series[0].Points.Clear();
                    this.chargraficaQ1.Series[1].Points.Clear();
                    this.chargraficaQ1.Series[2].Points.Clear();
                }
                //textos de prueba
                labelError.Text = controlPID.ErrorArray[0].ToString();
                labelError1.Text= controlPID.ErrorArray[1].ToString();
                labelError2.Text= controlPID.ErrorArray[2].ToString();
                labelPWM.Text = controlPID.PwmArray[0].ToString() + " " + controlPID.PwmArray[1].ToString();
                //encender el led
                if (int.Parse(comboBoxTemperatura.Text)>=temperatura1)
                {
                    VariablesControl.AlarmaLed1 = "on";
                }
                else
                {
                    VariablesControl.AlarmaLed1 = "off";
                }


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
