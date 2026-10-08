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
        private double kp = 0;
        private double ki = 0;
        private double kd = 0;
        private double ts = 0;

        private string titulo = "control";
        private string boton = "Refrescar";

        public double Kp { get { return kp; } set { kp = value; } }
        public double Ki { get { return ki; } set { ki = value; } }
        public double Kd { get { return kd; } set { kd = value; } }
        public double Ts { get { return ts; } set { ts = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Boton { get { return boton; } set { boton = value; } }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                
                kp = (this.textBoxKP.Text != "") ? double.Parse(this.textBoxKP.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                ki = (this.textBoxKI.Text != "") ? double.Parse(this.textBoxKI.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                kd = (this.textBoxKD.Text != "") ? double.Parse(this.textBoxKD.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                ts = (this.textBoxTS.Text != "") ? double.Parse(this.textBoxTS.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

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
            this.kp = kp;
            this.ki = ki;
            this.kd = kd;
            this.ts = ts;
        }

        private void ControlActual_Load(object sender, EventArgs e)
        {
            Text = titulo;
            buttonRefrescar.Text = boton;
            textBoxKP.Text = (kp != 0) ? kp.ToString() : "0";
            textBoxKI.Text = (ki != 0) ? ki.ToString() : "0";
            textBoxKD.Text = (kd != 0) ? kd.ToString() : "0";
            textBoxTS.Text = (ts != 0) ? ts.ToString() : "0";  
        }

    
    }
}
