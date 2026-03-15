using mqtt_serial.funciones;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        private string pathSave= @"C:\Users\CESAR\Desktop\DatosInterfaz\";
        private string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");//example20260315_123350 
       

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
            comboBoxPWM.Text=trackBarPWM.Value.ToString();
            timer1.Enabled = true;
            trackBarPWM.Value = 0;
            Directory.CreateDirectory(pathSave);
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            //codigo util
            labelCurrent.Text = "I1 " +VariablesControl.Corriente1;
            labelTemperature.Text = "T1 " + VariablesControl.Temperatura1;
            //enviar datos
            VariablesControl.Pwm1=trackBarPWM.Value.ToString();
            VariablesControl.AlarmaLed1 = comboBoxTemperatura.Text;
            //para graficar
            pwm = trackBarPWM.Value;
            temperatura1=double.Parse(VariablesControl.Temperatura1)/100;
            corriente1=(double.Parse(VariablesControl.Corriente1)/100)*1000;
            tiempo=double.Parse(VariablesControl.Tiempo)/100;
            if (tiempo > 10)
            {
                if (tiempo > 300)
                {
                    this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo-300;
                    //this.chargraficaQ1.ChartAreas[0].AxisX.Maximum = tiempo;
                }

                //
                VariablesControl.listaTemperatura1.Add(temperatura1);
                VariablesControl.listaCorriente1.Add(corriente1);
                VariablesControl.listaPWM1.Add(pwm);
                VariablesControl.listaTiempo.Add(tiempo);
                //

                //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;
                //chargraficaQ1.Series[1].IsVisibleInLegend = false;
                this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, corriente1)));
                this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, pwm)));


                
            }
            else
            {
                this.chargraficaQ1.Series[0].Points.Clear();
                this.chargraficaQ1.Series[1].Points.Clear();
                this.chargraficaQ1.Series[2].Points.Clear();
                
                VariablesControl.limpiarLista();
            }            
        }

        private void adquirir_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            //foreach(var punto in chargraficaQ1.Series[0].Points)
            //{
            //    double x = punto.XValue;
            //    double y = punto.YValues[0]; // Accede al primer valor Y
            //    Console.WriteLine($"X: {x}, Y: {y}");
            //}
            
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_Adquirir1_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);

            //Console.WriteLine(VariablesControl.listaTemperatura1.Count);
            if (VariablesControl.listaTiempo.Count>0)
            {
                SLDocument document = new SLDocument();

                document.SetCellValue(1, 1, "Tiempo");
                document.SetCellValue(1, 2, "Temperatura1");
                document.SetCellValue(1, 3, "Corriente1");
                document.SetCellValue(1, 4, "PWM1");
                for (int i=0; i<VariablesControl.listaTiempo.Count; i++)
                {
                    document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i].ToString());
                    document.SetCellValue(i+2, 2, VariablesControl.listaTemperatura1[i].ToString());
                    document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i].ToString());
                    document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i].ToString());
                }
                document.SaveAs($@"{pathSave}DatosGrafica_AdquirirQ1_{fecha}.xlsx");
            }
            timer1.Start();
            
            
        }
    }
}
