using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial
{
    public partial class ControlActual : Form
    {
        

        public double Kp { get; set; }
        public double Ki { get; set; }
        public double Kd { get; set ; }
        public double Ts { get; set ; }
        public string Titulo { get; set ; }
        public string Boton { get; set ;}

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Kp = (this.textBoxKP.Text != "") ? double.Parse(this.textBoxKP.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                Ki = (this.textBoxKI.Text != "") ? double.Parse(this.textBoxKI.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                Kd = (this.textBoxKD.Text != "") ? double.Parse(this.textBoxKD.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                Ts = (this.textBoxTS.Text != "") ? double.Parse(this.textBoxTS.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al parsear los valores: " + ex.Message);
            }
        }
        private void TextBox_SeleccionarTodo_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Pasa la ejecución al final de la cola de la interfaz para evitar que el clic del ratón desmarque la selección
                this.BeginInvoke((MethodInvoker)delegate
                {
                    textBox.SelectAll();
                });
            }
        }

        public ControlActual()
        {
            InitializeComponent();
            textBoxKP.Enter += TextBox_SeleccionarTodo_Enter;
            textBoxKI.Enter += TextBox_SeleccionarTodo_Enter;
            textBoxKD.Enter += TextBox_SeleccionarTodo_Enter;
            textBoxTS.Enter += TextBox_SeleccionarTodo_Enter;
        }
        public void variables(double kp, double ki, double kd, double ts)
        {
            this.Kp = kp;
            this.Ki = ki;
            this.Kd = kd;
            this.Ts = ts;
        }

        private void ControlActual_Load(object sender, EventArgs e)
        {
            Text = Titulo;
            buttonRefrescar.Text = Boton;
            textBoxKP.Text = (Kp != 0) ? Kp.ToString() : "0";
            textBoxKI.Text = (Ki != 0) ? Ki.ToString() : "0";
            textBoxKD.Text = (Kd != 0) ? Kd.ToString() : "0";
            textBoxTS.Text = (Ts != 0) ? Ts.ToString() : "0";  
        }

    
    }
}
