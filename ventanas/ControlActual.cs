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

        public double Kp { get { return kp; } set { kp = value; } }
        public double Ki { get { return ki; } set { ki = value; } }
        public double Kd { get { return kd; } set { kd = value; } }
        public double Ts { get { return ts; } set { ts = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            kp = (comboBoxKp.Text != "") ? double.Parse(comboBoxKp.Text, CultureInfo.InvariantCulture) : 0;
            ki = (comboBoxKi.Text != "") ? double.Parse(comboBoxKi.Text, CultureInfo.InvariantCulture) : 0;
            kd = (comboBoxKd.Text != "") ? double.Parse(comboBoxKd.Text, CultureInfo.InvariantCulture) : 0;
            ts = (comboBoxTs.Text != "") ? double.Parse(comboBoxTs.Text, CultureInfo.InvariantCulture) : 0;

            this.Close();
        }

        

        

        public ControlActual()
        {
            InitializeComponent();
        }

        private void ControlActual_Load(object sender, EventArgs e)
        {
            Text = titulo;
            comboBoxKd.Text=(kd != 0) ? kd.ToString() : "0";
            comboBoxKi.Text = (ki != 0) ? ki.ToString() : "0";
            comboBoxKp.Text = (kp != 0) ? kp.ToString() : "0";
            comboBoxTs.Text = (ts != 0) ? ts.ToString() : "0";  
        }

    
    }
}
