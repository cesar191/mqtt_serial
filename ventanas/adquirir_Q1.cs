using DocumentFormat.OpenXml.Wordprocessing;
using mqtt_serial.funciones;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        #region varianbles y path
        private double temperatura1, corriente1,tiempo,pwm;
        private string pathSave = VariablesControl.pathSave + @"AdquirirQ1\";
        #endregion
        public adquirir_Q1()
        {
            InitializeComponent();
            
        }
        #region encargados de manejar PWM
        private void trackBarPWM_Scroll(object sender, EventArgs e)
        {
            this.comboBoxPWM.Text=trackBarPWM.Value.ToString();
            VariablesControl.Pwm1 = trackBarPWM.Value.ToString();
        }


        private void comboBoxPWM_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                this.trackBarPWM.Value = (comboBoxPWM.Text != null) ? int.Parse(comboBoxPWM.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al parsear el valor del PWM: " + ex.Message);
            }

        }

        private void comboBoxPWM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxPWM.SelectionStart = comboBoxPWM.Text.Length;
                int numero = (comboBoxPWM.Text != null) ? int.Parse(comboBoxPWM.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                if (numero >=100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (numero <= 0)
                {
                    comboBoxPWM.Text="0";
                    this.trackBarPWM.Value = 0;
                }
                else {
                    
                    this.trackBarPWM.Value = numero;
                    this.comboBoxPWM.Text = (this.comboBoxPWM.Text[0] == '0') ? this.comboBoxPWM.Text.Substring(1) : this.comboBoxPWM.Text;

                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error al parsear el valor del PWM: " + error.Message);

            }
            
        }

        private void trackBarPWM_MouseDown(object sender, MouseEventArgs e)
        {

            // Limitar los márgenes internos aproximados del TrackBar
            double mousePosition = e.Y;
            double totalHeight = trackBarPWM.Height;

            // Normalizar la posición al rango del TrackBar (0 a 100)
            double valueRatio = mousePosition / totalHeight;
            int newValue = trackBarPWM.Maximum - (int)(valueRatio * (trackBarPWM.Maximum - trackBarPWM.Minimum));

            // Asegurar que se mantenga dentro de los límites
            if ((newValue - 5) <= trackBarPWM.Minimum) newValue = trackBarPWM.Minimum;
            if ((newValue + 5) >= trackBarPWM.Maximum) newValue = trackBarPWM.Maximum;

            trackBarPWM.Value = newValue;
            comboBoxPWM.Text = newValue.ToString();

        }

        #endregion
        #region abrir y cerrar ventana
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

        private void labelCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                if (chargraficaQ1.Series[1].Enabled)
                {
                    chargraficaQ1.Series[1].Enabled = false;
                }
                else
                {
                    chargraficaQ1.Series[1].Enabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error en: {error.Message}");
            }
        }

        private void adquirir_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

        }

        #endregion

        #region greficar y exportar 
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {
                //enviar datos
                VariablesControl.Pwm1 = trackBarPWM.Value.ToString();
              
                //para graficar
                pwm = trackBarPWM.Value;
                temperatura1 = (VariablesControl.Temperatura1 != "") ? double.Parse(VariablesControl.Temperatura1.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                
                corriente1 = (VariablesControl.Corriente1 != "") ? (double.Parse(VariablesControl.Corriente1.Replace(",", "."), CultureInfo.InvariantCulture)) * 1000 : 0;
                tiempo = (VariablesControl.Tiempo != "") ? double.Parse(VariablesControl.Tiempo.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                labelCorriente.Text = $@" {corriente1:f2} mA";
                labelTemperature.Text = $@" {temperatura1:f2} °C";
                
                
                

                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm);
                    VariablesControl.listaTiempo.Add(tiempo);

                    double tiempo2=tiempo - VariablesControl.listaTiempo[0];

                    double ventanaTiempo = 1200;
                    if (tiempo2 > ventanaTiempo)
                    {
                        double limiteInferior = tiempo2 - ventanaTiempo;

                        foreach (var area in chargraficaQ1.ChartAreas)
                        {
                            area.AxisX.Minimum = limiteInferior;
                            area.AxisX.Maximum = tiempo2;
                        }

                        foreach (var series in chargraficaQ1.Series)
                        {
                            while (series.Points.Count > 0 && series.Points[0].XValue < limiteInferior)
                            {
                                series.Points.RemoveAt(0);
                            }
                        }
                    }
                    else
                    {
                        foreach (var area in chargraficaQ1.ChartAreas)
                        {
                            area.AxisX.Minimum = 0;
                            area.AxisX.Maximum = tiempo2;
                        }
                    }

                    if (chargraficaQ1.Series.Count >= 2) { 
                            var series = chargraficaQ1.Series;
                            //series[1].Enabled = checkBoxCurrent.Checked;

                            series[0].Points.AddXY(tiempo2, temperatura1);
                            series[1].Points.AddXY(tiempo2, corriente1);
                            series[2].Points.AddXY(tiempo2, pwm);

                        }
                    
                }
                else if (tiempo < 10)
                {
                    foreach (var series in chargraficaQ1.Series)
                    {
                        series.Points.Clear();
                    }
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
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error en: {error.Message}");
            }
            
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                

                if (VariablesControl.listaTiempo.Count > 0)
                {
                    

                    SLDocument document = new SLDocument();

                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i] - VariablesControl.listaTiempo[0]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura1[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i]);
                    }
                    //modelo FOPDT
                    document.SetCellValue(1, 7, "FOPDT");
                    document.SetCellValue(2, 6, "Kgain");
                    document.SetCellValue(3, 6, "Tau/ts");
                    document.SetCellValue(4, 6, "Td");
                    // Fórmulas usando nombres en inglés, comas como separadores y el prefijo _xlfn.
                    document.SetCellValue(2, 7, "=(MAX(B:B)-MIN(B:B))/(MODE(D:D)-MIN(D:D))");
                    document.SetCellValue(3, 7, "=INDEX(A:A, MATCH(MAX(B:B)*0.632, B:B)) - (INDEX(A:A, MATCH(MODE(D:D), D:D,0))*1)");
                    document.SetCellValue(4, 7, "=INDEX(A:A, MATCH(MIN(B:B)*1.02, B:B)) - (INDEX(A:A, MATCH(MODE(D:D), D:D,0)))");

                    //imagen Grafica
                    if (this.chargraficaQ1 != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            this.chargraficaQ1.SaveImage(ms, System.Drawing.Imaging.ImageFormat.Png);
                            ms.Position = 0;

                            // Guardar copia física si se requiere
                            string rutaImagen = $@"{pathSave}Grafica_Adquirir1_{fecha}.png";
                            File.WriteAllBytes(rutaImagen, ms.ToArray());

                            // Usar la imagen desde el stream o archivo validando liberación
                            SLPicture imagenGrafica = new SLPicture(rutaImagen);
                            imagenGrafica.SetPosition(1, 8);
                            document.InsertPicture(imagenGrafica);
                        }
                    }

                    document.SaveAs($@"{pathSave}DatosGrafica_AdquirirQ1_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en la ubicacion: \n {pathSave}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error en: {error.Message}");
            }
            
        }
        
        #endregion

    }
}
