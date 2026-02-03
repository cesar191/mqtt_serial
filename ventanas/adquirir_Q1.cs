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
        //#region variablesControl
        //private string temperatura1;
        //private string temperatura2;
        //private string corriente1;
        //private string corriente2;
        //private string tiempo;

        //public string Temperatura1 { get { return temperatura1; } set { temperatura1 = value; } }
        //public string Temperatura2 { get { return temperatura2; } set { temperatura2 = value; } }
        //public string Corriente1 { get { return corriente1; } set { corriente1 = value; } }
        //public string Corriente2 { get { return corriente2; } set { corriente2 = value; } }
        //public string Tiempo { get { return tiempo; } set { tiempo = value; } }
        //#endregion 

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTemperatura1.Text = "T1 " + VariablesControl.Temperatura1;
            labelTemperatura2.Text = "T2 " + VariablesControl.Temperatura2;
            labelCorriente1.Text = "I1 " + VariablesControl.Corriente1;
            labelCorriente2.Text = "I2 " + VariablesControl.Corriente2;
            labelTiempo.Text = "time " + VariablesControl.Tiempo;
            VariablesControl.Pwm1=trackBarPWM.Value.ToString();
        }

        private void adquirir_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
