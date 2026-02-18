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

        #region ventanas
            conexion ventanaConexion;// = new conexion();    
            adquirir_Q1 ventanaAdquirirQ1;// = new adquirir_Q1();
            Adquirir_Q2 ventanaAdquirirQ2;
            control_Q1 ventanaControlQ1; 
            control_Q1Q2 ventanaControlQ1Q2;
        #endregion

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
            /*
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
            */

        private formhija AbrirSubVentana<formhija>() where formhija : Form, new()
        {
            formhija formulario;
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
                //pruba de ventana cerrada
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);


            }
            else { //si ya existe la ventana
                formulario.BringToFront();
            }
            return formulario;

        }
        
        //cerrar ventana
        private void CerrarForm<formhija>() where formhija : Form, new()
        {
            formhija formulario;
            formulario = this.panel_ventanas.Controls.OfType<formhija>().FirstOrDefault();
            if (formulario == null)//si no esta abierta la ventana
            {
               // MessageBox.Show("ventana no abierta");
            }
            else
            { //si ya existe la ventana
                formulario.Close();
                //MessageBox.Show("ventana cerrada");
            }
                
        }


        //cuando se incia la ventanta
        private void pantalla_principal_Load(object sender, EventArgs e)
        {
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(121, 33, 171);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            //por si acaso se asegura que las ventanas de pwm esten cerradas
            CerrarForm<adquirir_Q1>();
            CerrarForm<Adquirir_Q2>();
            CerrarForm<control_Q1>();
            CerrarForm<control_Q1Q2>();

            ventanaConexion = AbrirSubVentana<conexion>();
            
            
        }
        
        //al presionar el boton de conectar
        private void button_conexion_Click(object sender, EventArgs e)
        {
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(121, 33, 171);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);
            //abrir ventana
            ventanaConexion = AbrirSubVentana<conexion>();
            //labelPrueba.Text =ventanaConexion.Temperatura1;
            
        }
        //al presionar el boton de adquirir 1
        private void button_adquiri_q1_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(121,33,171);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            //si existe una ventana abierta se cierra diferente a la que se conecta
            CerrarForm<Adquirir_Q2>();
            CerrarForm<control_Q1>();
            CerrarForm<control_Q1Q2>();
            //se abre la ventana necesaria
            ventanaAdquirirQ1 = AbrirSubVentana<adquirir_Q1>();
            
        }
        
        
        //al presionar el boton de control Q1
        private void button_controlQ1_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(121, 53, 171);

            CerrarForm<adquirir_Q1>();
            CerrarForm<Adquirir_Q2>();
            //CerrarForm<control_Q1>();
            CerrarForm<control_Q1Q2>();

            ventanaControlQ1 = AbrirSubVentana<control_Q1>();

        }
        //al presionar el boton adquirir 2
        private void button_adquiri_q2_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(121,33, 171);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            CerrarForm<adquirir_Q1>();
            //CerrarForm<Adquirir_Q2>();
            CerrarForm<control_Q1>();
            CerrarForm<control_Q1Q2>();

            ventanaAdquirirQ2 = AbrirSubVentana<Adquirir_Q2>();
        }

        //al presionar el boton de control 2
        private void buttonControlQ1Q2_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(121,33,171);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            CerrarForm<adquirir_Q1>();
            CerrarForm<Adquirir_Q2>();
            CerrarForm<control_Q1>();
            //CerrarForm<control_Q1Q2>();

            ventanaControlQ1Q2 = AbrirSubVentana<control_Q1Q2>();
        }


        private void pantalla_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CerrarForm<conexion>();
            //CerrarForm<adquirir_Q1>();
            //CerrarForm<Adquirir_Q2>();
            //CerrarForm<control_Q1>();
            //CerrarForm<control_Q1Q2>();

        }
    }
}

