using mqtt_serial.ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial
{
    public partial class pantalla_principal : Form
    {
      
        public pantalla_principal()
        {
            InitializeComponent();
        }
        #region MoverVentana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void text_ventana_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        #region Cerrar_minimizar
        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        //función de sub-ventanas opción 1 problemas de memoria
        /*private void AbrirSubVentana(object formhija)
        {
            if (this.panel_ventanas.Controls.Count>0)
            {
                this.panel_ventanas.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_ventanas.Controls.Add(fh);
            this.panel_ventanas.Tag = fh;
            fh.Show();
        }*/
        //opción 2 mejor
        private void AbrirSubVentana<formhija>() where formhija : Form, new()
        {
            Form formulario;
            formulario=this.panel_ventanas.Controls.OfType<formhija>().FirstOrDefault();//busca ventanas ya abiertas
            if (formulario == null)//si no esta abierta la ventana
            {
                formulario = new formhija();
                formulario.TopLevel = false;
                formulario.Dock=DockStyle.Fill;
                this.panel_ventanas.Controls.Add(formulario);
                this.panel_ventanas.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else { //si ya existe la ventana
                formulario.BringToFront();
            }

        }
        //cuando se incia la ventan
        private void pantalla_principal_Load(object sender, EventArgs e)
        {
            //AbrirSubVentana(new conexion());//opción 1
            AbrirSubVentana<conexion>();//opción 2
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(121,33,171);
            this.button_adquiri_q1.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.button_controlQ1.BackColor= Color.FromArgb(58, 7, 88);

        }
        
        //al presionar el boton de conectar
        private void button_conexion_Click(object sender, EventArgs e)
        {
            AbrirSubVentana<conexion>();
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(121, 33, 171);
            this.button_adquiri_q1.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.button_controlQ1.BackColor = Color.FromArgb(58, 7, 88);

        }
        //al presionar el boton de adquirir 1
        private void button_adquiri_q1_Click(object sender, EventArgs e)
        {
            AbrirSubVentana<adquirir_Q1>();
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q1.BackColor = Color.FromArgb(121,33,171);
            this.button_adquiri_q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.button_controlQ1.BackColor = Color.FromArgb(58, 7, 88);

        }
        //al presionar el boton de control Q1
        private void button_controlQ1_Click(object sender, EventArgs e)
        {
            AbrirSubVentana<control_Q1>();
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q1.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.button_controlQ1.BackColor = Color.FromArgb(121, 53, 171);

        }
        //al presionar el boton adquirir 2
        private void button_adquiri_q2_Click(object sender, EventArgs e)
        {
            AbrirSubVentana<Adquirir_Q2>();
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q1.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q2.BackColor = Color.FromArgb(121,33, 171);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.button_controlQ1.BackColor = Color.FromArgb(58, 7, 88);
        }

        //al presionar el boton de control 2
        private void buttonControlQ1Q2_Click(object sender, EventArgs e)
        {
            AbrirSubVentana<control_Q1Q2>();
            //colores botones menu
            this.button_conexion.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q1.BackColor = Color.FromArgb(58, 7, 88);
            this.button_adquiri_q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(121,33,171);
            this.button_controlQ1.BackColor = Color.FromArgb(58, 7, 88);
        }

      
    }
}
