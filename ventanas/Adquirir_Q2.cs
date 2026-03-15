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
    public partial class Adquirir_Q2 : Form
    {

        private double temperatura2;
        //private string temperatura2;
        private double corriente2;
        private double tiempo;
        private double pwm;
        public Adquirir_Q2()
        {
            InitializeComponent();
        }

        private void trackBarPWM_Scroll(object sender, EventArgs e)
        {
            this.comboBoxPWM.Text = trackBarPWM.Value.ToString();
            VariablesControl.Pwm2= trackBarPWM.Value.ToString();
        }

        private void comboBoxPWM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPWM.Text == null)
                {
                    this.trackBarPWM.Value = 0;
                }
                else
                {
                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text);
                }
            }
            catch
            {

            }
        }

        private void Adquirir_Q2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Adquirir_Q2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            trackBarPWM.Value = 0;
        }

        private void comboBoxPWM_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (comboBoxPWM.Text == null)
                {
                    this.trackBarPWM.Value = 0;
                }
                else if (int.Parse(comboBoxPWM.Text) >= 100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (int.Parse(comboBoxPWM.Text) <= 0)
                {
                    comboBoxPWM.Text = "0";
                    this.trackBarPWM.Value = 0;
                }
                else
                {

                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //codigo util
            labelCurrent.Text = "I2 " + VariablesControl.Corriente2;
            labelTemperature.Text = "T2 " + VariablesControl.Temperatura2;
            //enviar datos
            VariablesControl.Pwm2 = trackBarPWM.Value.ToString();
            VariablesControl.AlarmaLed2 = comboBoxTemperatura.Text;
            //para graficar
            pwm = trackBarPWM.Value;
            temperatura2 = double.Parse(VariablesControl.Temperatura2) / 100;
            corriente2 = double.Parse(VariablesControl.Corriente2) / 100;
            tiempo = double.Parse(VariablesControl.Tiempo)/100;
            if (tiempo > 10)
            {
                if (tiempo > 300)
                {
                    this.chargraficaQ2.ChartAreas[0].AxisX.Minimum = tiempo - 300;
                    //this.chargraficaQ1.ChartAreas[0].AxisX.Maximum = tiempo;
                }
                //this.chargraficaQ2.Series[2].Name = "pwm";
                //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[0].Points.AddXY(tiempo, temperatura2)));
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[2].Points.AddXY(tiempo, corriente2)));
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[1].Points.AddXY(tiempo, pwm)));
            }
            else
            {
                this.chargraficaQ2.Series[0].Points.Clear();
                this.chargraficaQ2.Series[1].Points.Clear();
                this.chargraficaQ2.Series[2].Points.Clear();
            }
        }
    }
}
