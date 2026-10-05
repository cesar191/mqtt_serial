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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace mqtt_serial.ventanas
{
    public partial class ControlQ1 : Form
    {
        #region VariablesDeControl
        private ControlPID controlPID = new ControlPID();
        private double kp = 0, ki = 0, kd = 0,ts = 1, setPoint = 0, errorDouble = 0;

        #endregion
        
        #region variables recibidas y path de guardado
        private double temperatura1, corriente1,tiempo,pwm;
        private string pathSave = VariablesControl.pathSave + @"ControlQ1\";
        #endregion

        #region procesos de control
        private void SystemControl(double errorDouble, double kp, double ki, double kd, double ts)
        {
            ts = (ts != 0) ? (ts) : (1);
            if (kp != 0 && ki == 0 && kd == 0)
            {
                this.controlPID.SystemControlP(errorDouble, kp);
            }
            else if (kp != 0 && ki != 0 && kd == 0)
            {
                this.controlPID.SystemControlPI(errorDouble, kp, ki, ts);
            }
            else if (kp != 0 && ki != 0 && kd != 0)
            {
                this.controlPID.SystemControlPID(errorDouble, kp, ki, kd, ts);
            }
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (setPoint != 0)
                {
                    errorDouble = setPoint - temperatura1;
                    SystemControl(errorDouble, kp, ki, kd, ts);
                }
                else
                {
                    controlPID.PWM = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un Error: {ex.Message}");
            }
        }

        #endregion
        public ControlQ1()
        {
            InitializeComponent();
        }

        #region al abrir y cerrar la ventana
        private void control_Q1_Load(object sender, EventArgs e)
        {
            comboBoxSetPoint.Text = "0";
            textBoxKP.Text = "0";
            textBoxKI.Text = "0";
            textBoxKD.Text = "0";
            textBoxTS.Text = "0";

            chargraficaQ1.Series[1].Enabled = false;

            VariablesControl.limpiarLista();
            VariablesControl.reseteoParametros();

            Directory.CreateDirectory(pathSave);
            timer1.Enabled = true;

        }

        private void control_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {

            timer1.Enabled = false;
            timerControl.Enabled = false;

        }

        #endregion
        #region botones y graficas
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            try {
                controlPID.reseteo();
                kp = (textBoxKP.Text != "") ? double.Parse(textBoxKP.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                ki = (textBoxKI.Text != "") ? double.Parse(textBoxKI.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                kd = (textBoxKD.Text != "") ? double.Parse(textBoxKD.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                ts = (textBoxTS.Text != "") ? double.Parse(textBoxTS.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                
                VariablesControl.listaTiempo2.Add(tiempo);
                VariablesControl.listaKp.Add(kp);
                VariablesControl.listaKi.Add(ki);
                VariablesControl.listaKd.Add(kd);
                VariablesControl.listaTs.Add(ts);

                timerControl.Interval = (int)((ts != 0) ? (ts)*1000 : (1) * 1000);
                timerControl.Enabled = true;
            }
            catch (Exception ex) { 
                MessageBox.Show("Error al parsear los valores: " + ex.Message);
            }
        }

        private void buttonVentilador_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonVentilador.Text == "Encender")
                {
                    pictureBoxVentilador.Image = Properties.Resources.ventilador_on;
                    VariablesControl.Ventilador1 = "on";
                    buttonVentilador.Text = "Apagar";
                    buttonVentilador.BackColor = Color.FromArgb(227, 58, 24);
                }
                else
                {
                    buttonVentilador.Text = "Encender";
                    pictureBoxVentilador.Image = Properties.Resources.ventilador_off;
                    VariablesControl.Ventilador1 = "off";
                    buttonVentilador.BackColor = Color.FromArgb(44, 169, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un Error: {ex.Message}");
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
                    this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_ControlQ1_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);
                    SLDocument document = new SLDocument();

                    //lista de titulos del excel
                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    document.SetCellValue(1, 5, "SetPoint");

                    document.SetCellValue(1, 7, "Kp");
                    document.SetCellValue(1, 8, "Ki");
                    document.SetCellValue(1, 9, "Kd");
                    document.SetCellValue(1, 10, "Ts");
                    document.SetCellValue(1, 11, "Cambio (s)");

                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i] - VariablesControl.listaTiempo[0]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura1[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i]);
                        document.SetCellValue(i + 2, 5, VariablesControl.listaSetPoint1[i]);
                    }
                    for (int i = 0; i < VariablesControl.listaTiempo2.Count; i++)
                    {
                        document.SetCellValue(i + 2, 7, VariablesControl.listaKp[i]);
                        document.SetCellValue(i + 2, 8, VariablesControl.listaKi[i]);
                        document.SetCellValue(i + 2, 9, VariablesControl.listaKd[i]);
                        document.SetCellValue(i + 2, 10, VariablesControl.listaTs[i]);
                        document.SetCellValue(i + 2, 11, VariablesControl.listaTiempo2[i] - VariablesControl.listaTiempo[0]);

                    }
                    SLPicture imagenGrafica = new SLPicture($@"{pathSave}Grafica_ControlQ1_{fecha}.png");
                    imagenGrafica.SetPosition(1, 14);
                    document.InsertPicture(imagenGrafica);

                    document.SaveAs($@"{pathSave}DatosGrafica_ControlQ1_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en la ubicacion: \n {pathSave}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar los datos.por {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {        
                pwm = controlPID.PWM;
                labelPWM.Text = $@" {pwm:f2} %";
                VariablesControl.Pwm1 = pwm.ToString();

                temperatura1 = double.Parse(VariablesControl.Temperatura1.Replace(",", "."), CultureInfo.InvariantCulture);
                corriente1 = (double.Parse(VariablesControl.Corriente1.Replace(",", "."), CultureInfo.InvariantCulture)) * 1000;
                tiempo = double.Parse(VariablesControl.Tiempo.Replace(",", "."), CultureInfo.InvariantCulture);

                labelTemperature.Text = $@" {temperatura1:f2} °C";
                labelCorriente.Text = $@" {corriente1:f2} mA";
                

                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm);
                    VariablesControl.listaTiempo.Add(tiempo);
                    VariablesControl.listaSetPoint1.Add(setPoint);
                    //
                    setPoint = (comboBoxSetPoint.Text != "") ? double.Parse(comboBoxSetPoint.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                    double tiempo2 = tiempo - VariablesControl.listaTiempo[0];
                    //
                    double ventanaTiempo = 1200;
                    foreach (var area in chargraficaQ1.ChartAreas)
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
                    
                    if (chargraficaQ1.Series.Count >= 4)
                    {
                        // chargraficaQ1.Series[1].Enabled = checkBoxCurrent.Checked;

                        chargraficaQ1.Series[0].Points.AddXY(tiempo2, temperatura1);
                        chargraficaQ1.Series[1].Points.AddXY(tiempo2, corriente1);
                        chargraficaQ1.Series[2].Points.AddXY(tiempo2, pwm);
                        chargraficaQ1.Series[3].Points.AddXY(tiempo2, setPoint);
                    }
                }
                else if (tiempo <=10)
                {
                    foreach (var series in chargraficaQ1.Series)
                    {
                        series.Points.Clear();
                    }
                    VariablesControl.limpiarLista();
                }

                //encender el led
                if (double.TryParse(comboBoxTemperatura.Text, out double tempAlarma))
                {
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
                    VariablesControl.AlarmaLed1 = "off";
                    labelTemperature.ForeColor = System.Drawing.Color.White;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un Error: {ex.Message}");
            }

        }
        
        #endregion


    }
}
