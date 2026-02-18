using mqtt_serial.funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial.ventanas
{
    public partial class adquirir_Q1 : Form
    {
       
        private double temperatura1;
        //private string temperatura2;
        private double corriente1;
        private double tiempo;
        private double pwm;
       

        public adquirir_Q1()
        {
            InitializeComponent();
            
        }

        private void trackBarPWM_Scroll(object sender, EventArgs e)
        {
            this.comboBoxPWM.Text=trackBarPWM.Value.ToString();
            VariablesControl.Pwm1 = trackBarPWM.Value.ToString();
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

        private void comboBoxPWM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                if (comboBoxPWM.Text==null)
                {
                    this.trackBarPWM.Value = 0;
                }
                else if (int.Parse(comboBoxPWM.Text)>=100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (int.Parse(comboBoxPWM.Text) <= 0)
                {
                    comboBoxPWM.Text="0";
                    this.trackBarPWM.Value = 0;
                }
                else {
                    
                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text);   
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);

            }
            
        }

        private void adquirir_Q1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            trackBarPWM.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //test
            labelTemperatura1.Text = "T1 " + VariablesControl.Temperatura1;
            labelTemperatura2.Text = "T2 " + VariablesControl.Temperatura2;
            labelCorriente1.Text = "I1 " + VariablesControl.Corriente1;
            labelCorriente2.Text = "I2 " + VariablesControl.Corriente2;
            labelTiempo.Text = "time " + VariablesControl.Tiempo;
            //codigo util
            labelCurrent.Text = "I1 " +VariablesControl.Corriente1;
            labelTemperature.Text = "T1 " + VariablesControl.Temperatura1;
            //enviar datos
            VariablesControl.Pwm1=trackBarPWM.Value.ToString();
            VariablesControl.AlarmaLed1 = comboBoxTemperatura.Text;
            //para graficar
            pwm = trackBarPWM.Value;
            temperatura1=double.Parse(VariablesControl.Temperatura1)/100;
            corriente1=double.Parse(VariablesControl.Corriente1)/100;
            tiempo=double.Parse(VariablesControl.Tiempo);
            if (tiempo > 10)
            {
                if (tiempo > 300)
                {
                    this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo-300;
                    //this.chargraficaQ1.ChartAreas[0].AxisX.Maximum = tiempo;
                }
                this.chargraficaQ1.Series[2].Name = "pwm";
                //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;
                this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                //this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, pwm)));
                this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, pwm)));
            }
            else
            {
                this.chargraficaQ1.Series[0].Points.Clear();
                this.chargraficaQ1.Series[1].Points.Clear();
                this.chargraficaQ1.Series[2].Points.Clear();
            }            
        }

        private void adquirir_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
