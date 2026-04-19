using mqtt_serial.funciones;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial.ventanas
{
    public partial class Adquirir_Q2 : Form
    {

        private double temperatura2;
        //private string temperatura2;
        private double corriente2;
        private double tiempo;
        private double pwm;

        private string pathSave=VariablesControl.pathSave+@"AdquirirQ2\";
        public Adquirir_Q2()
        {
            InitializeComponent();
        }

        private void trackBarPWM_Scroll(object sender, EventArgs e)
        {
            this.comboBoxPWM.Text = trackBarPWM.Value.ToString();
            VariablesControl.Pwm2= trackBarPWM.Value.ToString();
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

        private void Adquirir_Q2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Adquirir_Q2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            trackBarPWM.Value = 0;
            Directory.CreateDirectory(pathSave);
        }
        

        private void comboBoxPWM_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (comboBoxPWM.Text == null)
                {
                    this.trackBarPWM.Value = 0;
                }
                else if (int.Parse(comboBoxPWM.Text) >= 100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (int.Parse(comboBoxPWM.Text) <= 0)
                {
                    comboBoxPWM.Text = "0";
                    this.trackBarPWM.Value = 0;
                }
                else
                {

                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //enviar datos
            VariablesControl.Pwm2 = trackBarPWM.Value.ToString();
            
            //para graficar
            pwm = trackBarPWM.Value;
            temperatura2 = double.Parse(VariablesControl.Temperatura2.Replace('.', ','));
            corriente2 = (double.Parse(VariablesControl.Corriente2.Replace('.', ','))) * 1000;
            tiempo = double.Parse(VariablesControl.Tiempo.Replace('.', ','));

            checkBoxCurrent.Text = " " + corriente2 + " mA";
            labelTemperature.Text = " " + temperatura2 + " °C";


            if (checkBoxCurrent.Checked)
            {
                this.chargraficaQ2.Series[1].Enabled = true;
            }
            else
            {
                this.chargraficaQ2.Series[1].Enabled = false;
            }


            if (tiempo > 10 && VariablesControl.EstadoDeConexion)
            {
                //this.chargraficaQ2.Series[0].Enabled = false;
                //
                VariablesControl.listaTemperatura2.Add(temperatura2);
                VariablesControl.listaCorriente2.Add(corriente2);
                VariablesControl.listaPWM2.Add(pwm);
                VariablesControl.listaTiempo.Add(tiempo);
                //
                //this.chargraficaQ2.Series[2].Name = "pwm";
                //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[0].Points.AddXY(tiempo, temperatura2)));
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[1].Points.AddXY(tiempo, corriente2)));
                this.chargraficaQ2.Invoke((MethodInvoker)(() => chargraficaQ2.Series[2].Points.AddXY(tiempo, pwm)));
            }
            else if(VariablesControl.EstadoDeConexion)
            {
                this.chargraficaQ2.Series[0].Points.Clear();
                this.chargraficaQ2.Series[1].Points.Clear();
                this.chargraficaQ2.Series[2].Points.Clear();
                VariablesControl.limpiarLista();
            }


            if (double.TryParse(comboBoxTemperatura.Text, out double tempAlarma))
            {
                // La conversión fue exitosa, ahora comparamos
                if (tempAlarma <= temperatura2)
                {
                    VariablesControl.AlarmaLed2 = "on";
                    labelTemperature.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    VariablesControl.AlarmaLed2 = "off";
                    labelTemperature.ForeColor = System.Drawing.Color.White;
                }
            }
            else
            {
                // Opcional: Manejar el caso donde el texto no es un número válido
                VariablesControl.AlarmaLed2 = "off";
                labelTemperature.ForeColor = System.Drawing.Color.White;
            }
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                //alternativa para que el usuario escoga donde guardar la informacion
                //if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
                //{
                //    Console.WriteLine(folderBrowserDialog1.SelectedPath);
                //}
                string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                this.chargraficaQ2.SaveImage($@"{pathSave}Grafica_AdquirirQ2_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);

                if (VariablesControl.listaTiempo.Count > 0)
                {
                    SLDocument document = new SLDocument();

                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura2");
                    document.SetCellValue(1, 3, "Corriente2");
                    document.SetCellValue(1, 4, "PWM2");
                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura2[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente2[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM2[i]);
                    }
                    document.SaveAs($@"{pathSave}DatosGrafica_AdquirirQ2_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en: \n {pathSave}");
            }
            catch
            {
                MessageBox.Show("hubo en error al exportar");
            }


        }

        
    }
}
