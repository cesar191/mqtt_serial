using DocumentFormat.OpenXml.Wordprocessing;
using mqtt_serial.funciones;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mqtt_serial.ventanas
{
    public partial class adquirir_Q1 : Form
    {
       
        private double temperatura1;
        private double corriente1;
        private double tiempo;
        private double pwm;
        private string pathSave = VariablesControl.pathSave + @"AdquirirQ1\";
        
       

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
                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text.Replace('.', ','));
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
                this.comboBoxPWM.SelectionStart = comboBoxPWM.Text.Length;

                if (comboBoxPWM.Text==null || comboBoxPWM.Text=="")
                {
                    this.trackBarPWM.Value = 0;
                    comboBoxPWM.Text = "0";
                }
                else if (int.Parse(comboBoxPWM.Text.Replace('.', ','))>=100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (int.Parse(comboBoxPWM.Text.Replace('.', ',')) <= 0)
                {
                    comboBoxPWM.Text="0";
                    this.trackBarPWM.Value = 0;
                }
                else {
                    
                    this.trackBarPWM.Value = int.Parse(comboBoxPWM.Text.Replace('.', ','));
                    if (this.comboBoxPWM.Text[0]=='0')
                    {
                        this.comboBoxPWM.Text=this.comboBoxPWM.Text.Substring(1);
                        
                    }
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
            //limpiar lista de datos y crear la carpeta donde se alojan los datos e imagen de proceso
            VariablesControl.limpiarLista();
            VariablesControl.reseteoParametros();

            Directory.CreateDirectory(pathSave);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //codigo util
            try
            {
                //enviar datos
                VariablesControl.Pwm1 = trackBarPWM.Value.ToString();
                //VariablesControl.AlarmaLed1 = comboBoxTemperatura.Text;

                //para graficar
                pwm = trackBarPWM.Value;
                temperatura1 = double.Parse(VariablesControl.Temperatura1.Replace('.', ','));
                corriente1 = (double.Parse(VariablesControl.Corriente1.Replace('.', ','))) * 1000;
                tiempo = double.Parse(VariablesControl.Tiempo.Replace('.', ','));


                checkBoxCurrent.Text = " " + corriente1 + " mA";
                labelTemperature.Text = " " + temperatura1 + " °C";
                if (checkBoxCurrent.Checked)
                {
                    this.chargraficaQ1.Series[1].Enabled = true;
                }
                else
                {
                    this.chargraficaQ1.Series[1].Enabled = false;
                }
                //testeo de configuracion grafica
                this.chargraficaQ1.Legends[0].CellColumns[0].SeriesSymbolSize = new Size(200,100);

                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm);
                    VariablesControl.listaTiempo.Add(tiempo);

                    //int axisGraficaX = 600;
                    //if (tiempo - VariablesControl.listaTiempo[0] > axisGraficaX)
                    //{
                    //   this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo - axisGraficaX;
                    //   this.chargraficaQ1.ChartAreas[1].AxisX.Minimum = tiempo - axisGraficaX;
                    //}
                    

                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, corriente1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, pwm)));

                    



                }
                else if (tiempo < 10)
                {
                    this.chargraficaQ1.Series[0].Points.Clear();
                    this.chargraficaQ1.Series[1].Points.Clear();
                    this.chargraficaQ1.Series[2].Points.Clear();

                    VariablesControl.limpiarLista();
                }

                if (double.TryParse(comboBoxTemperatura.Text, out double tempAlarma))
                {
                    // La conversión fue exitosa, ahora comparamos
                    if (tempAlarma <= temperatura1)
                    {
                        VariablesControl.AlarmaLed1 = "on";
                        labelTemperature.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        VariablesControl.AlarmaLed1 = "off";
                        labelTemperature.ForeColor = System.Drawing.Color.White;
                    }
                }
                else
                {
                    // Opcional: Manejar el caso donde el texto no es un número válido
                    VariablesControl.AlarmaLed1 = "off";
                    labelTemperature.ForeColor = System.Drawing.Color.White;
                }
            }
            catch
            {

            }
            
        }

        private void adquirir_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

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
                

                if (VariablesControl.listaTiempo.Count > 0)
                {
                    
                    this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_Adquirir1_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);
                    SLDocument document = new SLDocument();

                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura1[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i]);
                    }
                    //modelo FODPT
                    document.SetCellValue(1, 7, "FODPT");
                    document.SetCellValue(2, 6, "Kgain");
                    document.SetCellValue(3, 6, "Tau/ts");
                    document.SetCellValue(4, 6, "Td");
                    // Fórmulas usando nombres en inglés, comas como separadores y el prefijo _xlfn.
                    document.SetCellValue(2, 7, "=(MAX(B:B)-MIN(B:B))/(MODE(D:D)-MIN(D:D))");
                    document.SetCellValue(3, 7, "=INDEX(A:A, MATCH(MAX(B:B)*0.632, B:B)) - (INDEX(A:A, MATCH(MODE(D:D), D:D,0))*1)");
                    document.SetCellValue(4, 7, "=INDEX(A:A, MATCH(MIN(B:B)*1.02, B:B)) - (INDEX(A:A, MATCH(MODE(D:D), D:D,0)))");

                    //imagen Grafica
                    SLPicture imagenGrafica = new SLPicture($@"{pathSave}Grafica_Adquirir1_{fecha}.png");
                    imagenGrafica.SetPosition(1, 8);
                    document.InsertPicture(imagenGrafica);

                    document.SaveAs($@"{pathSave}DatosGrafica_AdquirirQ1_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en la ubicacion: \n {pathSave}");
            }
            catch
            {

            }
            
        }


        private void trackBarPWM_MouseDown(object sender, MouseEventArgs e)
        {

            // Limitar los márgenes internos aproximados del TrackBar
            double mousePosition = e.Y;
            double totalHeight = trackBarPWM.Height;

            // Normalizar la posición al rango del TrackBar (0 a 100)
            double valueRatio = mousePosition / totalHeight;
            int newValue = trackBarPWM.Maximum - (int)(valueRatio * (trackBarPWM.Maximum - trackBarPWM.Minimum)) ;

            // Asegurar que se mantenga dentro de los límites
            if ((newValue-5) <= trackBarPWM.Minimum) newValue = trackBarPWM.Minimum;
            if ((newValue+5) >= trackBarPWM.Maximum) newValue = trackBarPWM.Maximum;

            trackBarPWM.Value = newValue;
            comboBoxPWM.Text = newValue.ToString();

        }
    }
}
