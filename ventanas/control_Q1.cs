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
        public control_Q1()
        {
            InitializeComponent();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            labelKp.Text = comboBoxKp.Text;
            labelKI.Text=comboBoxKi.Text;
            labelKd.Text=comboBoxKd.Text;
            labelTs.Text=comboBoxTs.Text;
        }
    }
}
