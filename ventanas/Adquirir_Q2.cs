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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mqtt_serial.ventanas
{
    public partial class Adquirir_Q2 : Form
    {
        #region variables y path

        private double temperatura2, corriente2, tiempo,pwm;
        
        private string pathSave=VariablesControl.pathSave+@"AdquirirQ2\";
        #endregion
        public Adquirir_Q2()
        {
            InitializeComponent();
        }
        #region encargados de manejar PWM

        private void trackBarPWM_Scroll(object sender, EventArgs e)
        {
            this.comboBoxPWM.Text = trackBarPWM.Value.ToString();
            VariablesControl.Pwm2= trackBarPWM.Value.ToString();
        }

        private void comboBoxPWM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    this.trackBarPWM.Value = (comboBoxPWM.Text!=null) ? int.Parse(comboBoxPWM.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"hubo un error en: {ex.Message}");
            }
        }

        private void comboBoxPWM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxPWM.SelectionStart = comboBoxPWM.Text.Length;

                int numero = (comboBoxPWM.Text != null) ? int.Parse(comboBoxPWM.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                if (numero >= 100)
                {
                    comboBoxPWM.Text = "100";
                    this.trackBarPWM.Value = 100;
                }
                else if (numero <= 0)
                {
                    comboBoxPWM.Text = "0";
                    this.trackBarPWM.Value = 0;
                }
                else
                {
                    this.trackBarPWM.Value = numero;
                    this.comboBoxPWM.Text = (this.comboBoxPWM.Text[0] == '0') ? this.comboBoxPWM.Text.Substring(1) : this.comboBoxPWM.Text;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error en: {error.Message}");

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
        private void Adquirir_Q2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Adquirir_Q2_Load(object sender, EventArgs e)
        {
            comboBoxPWM.Text = trackBarPWM.Value.ToString();
            timer1.Enabled = true;
            trackBarPWM.Value = 0;
            Directory.CreateDirectory(pathSave);

            VariablesControl.reseteoParametros();
            VariablesControl.limpiarLista();
        }
        #endregion
        #region graficar y exportar
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //enviar datos
                VariablesControl.Pwm2 = trackBarPWM.Value.ToString();

                //para graficar
                pwm = trackBarPWM.Value;
                temperatura2 = (VariablesControl.Temperatura2 != "") ? double.Parse(VariablesControl.Temperatura2.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                corriente2 = (VariablesControl.Corriente2 != "") ? (double.Parse(VariablesControl.Corriente2.Replace(",", "."), CultureInfo.InvariantCulture) * 1000) : 0;
                tiempo = (VariablesControl.Tiempo != "") ? double.Parse(VariablesControl.Tiempo.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                checkBoxCurrent.Text = $@" {corriente2:f2} mA";
                labelTemperature.Text = $@" {temperatura2:f2} °C";


                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    
                    VariablesControl.listaTemperatura2.Add(temperatura2);
                    VariablesControl.listaCorriente2.Add(corriente2);
                    VariablesControl.listaPWM2.Add(pwm);
                    VariablesControl.listaTiempo.Add(tiempo);
                    
                    double tiempo2 = tiempo - VariablesControl.listaTiempo[0];
                    double ventanaTiempo = 1200;
                    foreach (var area in chargraficaQ2.ChartAreas)
                    {
                        if (tiempo - VariablesControl.listaTiempo[0] > ventanaTiempo)
                        {
                            area.AxisX.Minimum = tiempo2 - ventanaTiempo;
                            area.AxisX.Maximum = tiempo2;
                        }
                        else
                        {
                            area.AxisX.Minimum = 0;
                            area.AxisX.Maximum = tiempo2;
                        }
                    }
                    //
                    if (chargraficaQ2.Series.Count >= 3)
                    {
                        var series = chargraficaQ2.Series;

                        series[1].Enabled = checkBoxCurrent.Checked;

                        series[0].Points.AddXY(tiempo2, temperatura2);
                        series[1].Points.AddXY(tiempo2, corriente2);
                        series[2].Points.AddXY(tiempo2, pwm);
                    }

                }
                else if (tiempo < 10)
                {
                    foreach (var series in chargraficaQ2.Series)
                    {
                        series.Points.Clear();
                    }
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
            catch (Exception error)
            {
                MessageBox.Show($"Hubo un error: {error.Message}");
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
                    this.chargraficaQ2.SaveImage($@"{pathSave}Grafica_AdquirirQ2_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);
                    SLDocument document = new SLDocument();

                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura2");
                    document.SetCellValue(1, 3, "Corriente2");
                    document.SetCellValue(1, 4, "PWM2");
                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i] - VariablesControl.listaTiempo[0]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura2[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente2[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM2[i]);
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

                    SLPicture imagenGrafica = new SLPicture($@"{pathSave}Grafica_AdquirirQ2_{fecha}.png");
                    
                    imagenGrafica.SetPosition(1, 8);
                    document.InsertPicture(imagenGrafica);

                    document.SaveAs($@"{pathSave}DatosGrafica_AdquirirQ2_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en: \n {pathSave}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"hubo un error al exportar: {error.Message}");
            }


        }
        #endregion
    }
}
