using mqtt_serial.funciones;
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
            Conexion ventanaConexion;    
            AdquirirQ1 ventanaAdquirirQ1;
            AdquirirQ2 ventanaAdquirirQ2;
            ControlQ1 ventanaControlQ1; 
            ControlQ1Q2 ventanaControlQ1Q2;
        #endregion

        public pantalla_principal()
        {
            InitializeComponent();       
        }
        #region panel abrir y cerrar ventanas
        //ver las ventansa en el panel deseado
        private formhija AbrirSubVentana<formhija>() where formhija : Form, new()
        {
            formhija formulario;
            formulario=this.panel_ventanas.Controls.OfType<formhija>().FirstOrDefault();//busca ventanas ya abiertas
            if (formulario == null)
            {
                formulario = new formhija();
                formulario.TopLevel = false;
                formulario.Dock=DockStyle.Fill;
                this.panel_ventanas.Controls.Add(formulario);
                this.panel_ventanas.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else { 
                formulario.BringToFront();
            }
            return formulario;
        }
       
        
        //cerrar ventanas 
        private void CerrarForm<formhija>() where formhija : Form, new()
        {
            formhija formulario;
            formulario = this.panel_ventanas.Controls.OfType<formhija>().FirstOrDefault();
            if (!(formulario == null))
            { 
                formulario.Close(); 
            }
                
        }
        #endregion
        #region arranque y cierre de la aplicacion
        private void pantalla_principal_Load(object sender, EventArgs e)
        {
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(121, 33, 171);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            ventanaConexion = AbrirSubVentana<Conexion>();
            buttonEstadoConexion.Visible = VariablesControl.EstadoDeConexion;

        }

        private void pantalla_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ventanaConexion != null && !ventanaConexion.IsDisposed)
            {
                this.ventanaConexion.desconectar();
            }
            CerrarForm<Conexion>();
            CerrarForm<AdquirirQ1>();
            CerrarForm<AdquirirQ2>();
            CerrarForm<ControlQ1>();
            CerrarForm<ControlQ1Q2>();

        }
        #endregion

        #region botones menu
        private void button_conexion_Click(object sender, EventArgs e)
        {
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(121, 33, 171);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);
            //abrir ventana
            ventanaConexion = AbrirSubVentana<Conexion>();
            buttonEstadoConexion.Visible = false;

        }

        private void button_adquiri_q1_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(121,33,171);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            //si existe una ventana abierta se cierra diferente a la que se conecta
            CerrarForm<AdquirirQ2>();
            CerrarForm<ControlQ1>();
            CerrarForm<ControlQ1Q2>();
            //se abre la ventana necesaria
            ventanaAdquirirQ1 = AbrirSubVentana<AdquirirQ1>();

            buttonEstadoConexion.Visible = VariablesControl.EstadoDeConexion;

        }
        private void button_adquiri_q2_Click(object sender, EventArgs e)
        {

            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(121, 33, 171);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            CerrarForm<AdquirirQ1>();
            //CerrarForm<Adquirir_Q2>();
            CerrarForm<ControlQ1>();
            CerrarForm<ControlQ1Q2>();

            ventanaAdquirirQ2 = AbrirSubVentana<AdquirirQ2>();
            buttonEstadoConexion.Visible = VariablesControl.EstadoDeConexion;
        }

        private void button_controlQ1_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1.BackColor = Color.FromArgb(121, 53, 171);

            CerrarForm<AdquirirQ1>();
            CerrarForm<AdquirirQ2>();
            //CerrarForm<control_Q1>();
            CerrarForm<ControlQ1Q2>();

            ventanaControlQ1 = AbrirSubVentana<ControlQ1>();
            buttonEstadoConexion.Visible = VariablesControl.EstadoDeConexion;
        }
        
        

        private void buttonControlQ1Q2_Click(object sender, EventArgs e)
        {
            
            //colores botones menu
            this.buttonConexion.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ1.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonAdquiriQ2.BackColor = Color.FromArgb(58, 7, 88);
            this.buttonControlQ1Q2.BackColor = Color.FromArgb(121,33,171);
            this.buttonControlQ1.BackColor = Color.FromArgb(58, 7, 88);

            CerrarForm<AdquirirQ1>();
            CerrarForm<AdquirirQ2>();
            CerrarForm<ControlQ1>();
            //CerrarForm<control_Q1Q2>();

            ventanaControlQ1Q2 = AbrirSubVentana<ControlQ1Q2>();
            buttonEstadoConexion.Visible = VariablesControl.EstadoDeConexion;
        }

        private void buttonEstadoConexion_Click(object sender, EventArgs e)
        {
            this.ventanaConexion.desconectar();
            VariablesControl.EstadoDeConexion = false;
            buttonEstadoConexion.Visible = false;
        }
        
        #endregion

    }
}

   