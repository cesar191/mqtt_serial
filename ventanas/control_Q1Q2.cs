using DocumentFormat.OpenXml.Presentation;

using mqtt_serial.funciones;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mqtt_serial.ventanas
{
    public partial class control_Q1Q2 : Form
    {
    #region parametros de  control y medicion
        private double temperatura1, temperatura2, corriente1, corriente2, tiempo,pwm1,pwm2;
        private double setPoint1 = 0, setPoint2 = 0, errorDouble1 = 0, errorDouble2 = 0;
        private double kp1 = 0, kp2 = 0, ki1 = 0, ki2 = 0, kd1 = 0, kd2 = 0, ts1 = 1, ts2 = 1;


        ControlActual controlActulizar = new ControlActual();

        private ControlPID controlPIDQ1 = new ControlPID();
        private ControlPID controlPIDQ2 = new ControlPID();

        #endregion

        private string pathSave = VariablesControl.pathSave + @"ControlQ1Q2\";

        private void SystemControl(double errorDouble, double kp, double ki, double kd, double ts, ControlPID control)
        {
            ts = (ts != 0) ? (ts) : (1);
            if (kp != 0 && ki == 0 && kd == 0)
            {
                control.SystemControlP(errorDouble, kp);
                
            }
            else if (kp != 0 && ki != 0 && kd == 0)
            {
                control.SystemControlPI(errorDouble, kp, ki, ts);
            }
            else if (kp != 0 && ki != 0 && kd != 0)
            {
                control.SystemControlPID(errorDouble, kp, ki, kd, ts);
            }
            

        }


        private void timerControl1_Tick(object sender, EventArgs e)
        {
            if (setPoint1 != 0)
            {
                errorDouble1 = setPoint1 - temperatura1;
                SystemControl(errorDouble1, kp1, ki1, kd1, ts1, controlPIDQ1);
            }
            else
            {
                controlPIDQ1.PWM = 0;
            }
        }
        private void timerControl2_Tick(object sender, EventArgs e)
        {
            if(setPoint2 != 0)
            {
                errorDouble2 = setPoint2 - temperatura2;
                SystemControl(errorDouble2, kp2, ki2, kd2, ts2, controlPIDQ2);
            }
            else
            {
                controlPIDQ2.PWM = 0;
            }   
        }


        public control_Q1Q2()
        {
            InitializeComponent();
        }

        private void control_Q1Q2_Load(object sender, EventArgs e)
        {
            comboBoxSetPointQ1.Text = "0";
            comboBoxSetPointQ2.Text = "0";

            VariablesControl.limpiarLista();
            VariablesControl.reseteoParametros();

            Directory.CreateDirectory(pathSave);
            timer1.Enabled = true;

        }

        private void control_Q1Q2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timerControl1.Enabled = false;
            timerControl2.Enabled = false;
        }

        private void buttoActualizarQ2_Click(object sender, EventArgs e)
        {
            controlPIDQ2.reseteo();
            controlActulizar.Titulo = "Parametros Control Q2";
            controlActulizar.Boton = "Refrescar Q2";
            controlActulizar.variables(kp2, ki2, kd2, ts2);
            controlActulizar.ShowDialog();

            kp2 = controlActulizar.Kp;
            ki2 = controlActulizar.Ki;
            kd2 = controlActulizar.Kd;
            ts2 = controlActulizar.Ts;

            

            string kpText = (kp2 != 0) ? $"Kp = {kp2:f4}{Environment.NewLine}" : "";
            string kiText = (ki2 != 0) ? $"Ki = {ki2:f4}{Environment.NewLine}" : "";
            string kdText = (kd2 != 0) ? $"Kd = {kd2:f4}{Environment.NewLine}" : "";
            string tsText = (ts2 != 0) ? $"Ts = {ts2:f4}" : "";


            labelControlQ2.Text = $@"{kpText}{kiText}{kdText}{tsText}";

            //para exportar al exce
            VariablesControl.listaKp.Add(kp2);
            VariablesControl.listaKi.Add(ki2);
            VariablesControl.listaKd.Add(kd2);
            VariablesControl.listaTs.Add(ts2);
            VariablesControl.listaTiempo2.Add(tiempo);
            VariablesControl.PlantaControl.Add("Q2");

            timerControl2.Interval = (int)((ts2 != 0) ? ts2 * 1000 : 1000);
            timerControl2.Enabled = true;

        }

        private void buttonActulizarQ1_Click(object sender, EventArgs e)
        {

            controlPIDQ1.reseteo();

            controlActulizar.Titulo = "Parametros Control Q1";
            controlActulizar.Boton = "Refrescar Q1";
            controlActulizar.variables(kp1, ki1, kd1, ts1);
            controlActulizar.ShowDialog();

            kp1 = controlActulizar.Kp;
            ki1 = controlActulizar.Ki;
            kd1 = controlActulizar.Kd;
            ts1 = controlActulizar.Ts;

            

            string kpText = (kp1 != 0) ? $"Kp = {kp1:f4}{Environment.NewLine}" : "";
            string kiText = (ki1 != 0) ? $"Ki = {ki1:f4}{Environment.NewLine}" : "";
            string kdText = (kd1 != 0) ? $"Kd = {kd1:f4}{Environment.NewLine}" : "";
            string tsText = (ts1 != 0) ? $"Ts = {ts1:f4}" : "";

            labelControlQ1.Text = $@"{kpText}{kiText}{kdText}{tsText}";

            //para exportar al excel
            VariablesControl.listaKp.Add(kp1);
            VariablesControl.listaKi.Add(ki1);
            VariablesControl.listaKd.Add(kd1);
            VariablesControl.listaTs.Add(ts1);
            VariablesControl.listaTiempo2.Add(tiempo);
            VariablesControl.PlantaControl.Add("Q1");

            timerControl1.Interval = (int)((ts1 != 0) ? ts1 * 1000 : 1000);
            timerControl1.Enabled = true;
        }


        private void buttonVentiladorQ1_Click(object sender, EventArgs e)
        {
            try {
                if (buttonVentiladorQ1.Text == "Encender")
                {
                    pictureBoxVentiladorQ1.Image = Properties.Resources.ventilador_on;
                    VariablesControl.Ventilador1 = "on";
                    buttonVentiladorQ1.Text = "Apagar";
                    buttonVentiladorQ1.BackColor = Color.FromArgb(227, 58, 24);
                }
                else
                {
                    buttonVentiladorQ1.Text = "Encender";
                    buttonVentiladorQ1.BackColor = Color.FromArgb(44, 169, 94);
                    pictureBoxVentiladorQ1.Image = Properties.Resources.ventilador_off;
                    VariablesControl.Ventilador1 = "off";
                }
            } catch (Exception ex) {
                MessageBox.Show("error por " + ex);
            }
        }

        private void buttonVentiladorQ2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonVentiladorQ2.Text == "Encender")
                {
                    pictureBoxVentiladorQ2.Image = Properties.Resources.ventilador_on;
                    VariablesControl.Ventilador2 = "on";
                    buttonVentiladorQ2.Text = "Apagar";
                    buttonVentiladorQ2.BackColor = Color.FromArgb(227, 58, 24);
                }
                else
                {
                    buttonVentiladorQ2.Text = "Encender";
                    buttonVentiladorQ2.BackColor = Color.FromArgb(44, 169, 94);
                    pictureBoxVentiladorQ2.Image = Properties.Resources.ventilador_off;
                    VariablesControl.Ventilador2 = "off";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error por " + ex);
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
                    this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_ControlQ1Q2_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);

                    SLDocument document = new SLDocument();
                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    document.SetCellValue(1, 5, "SetPoint1");

                    document.SetCellValue(1, 6, "Temperatura2");
                    document.SetCellValue(1, 7, "Corriente2");
                    document.SetCellValue(1, 8, "PWM2");
                    document.SetCellValue(1, 9, "SetPoint2");

                    document.SetCellValue(1, 11, "Kp");
                    document.SetCellValue(1, 12, "Ki");
                    document.SetCellValue(1, 13, "Kd");
                    document.SetCellValue(1, 14, "Ts");
                    document.SetCellValue(1, 15, "Cambio (s)");
                    document.SetCellValue(1, 16, "Planta");
                    

                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i] - VariablesControl.listaTiempo[0]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura1[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i]);
                        document.SetCellValue(i + 2, 5, VariablesControl.listaSetPoint1[i]);

                        document.SetCellValue(i + 2, 6, VariablesControl.listaTemperatura2[i]);
                        document.SetCellValue(i + 2, 7, VariablesControl.listaCorriente2[i]);
                        document.SetCellValue(i + 2, 8, VariablesControl.listaPWM2[i]);
                        document.SetCellValue(i + 2, 9, VariablesControl.listaSetPoint2[i]);
                    }

                    for (int i=0; i<VariablesControl.listaTiempo2.Count;i++)
                    {
                        document.SetCellValue(i + 2, 11, VariablesControl.listaKp[i]);
                        document.SetCellValue(i + 2, 12, VariablesControl.listaKi[i]);
                        document.SetCellValue(i + 2, 13, VariablesControl.listaKd[i]);
                        document.SetCellValue(i + 2, 14, VariablesControl.listaTs[i]);
                        document.SetCellValue(i + 2, 15, VariablesControl.listaTiempo2[i]-VariablesControl.listaTiempo[0]);
                        document.SetCellValue(i + 2, 16, VariablesControl.PlantaControl[i]);
                        
                    }
                    SLPicture imagenGrafica = new SLPicture($@"{pathSave}Grafica_ControlQ1Q2_{fecha}.png");
                    imagenGrafica.SetPosition(1,19);
                    document.InsertPicture(imagenGrafica);
                    document.SaveAs($@"{pathSave}DatosGrafica_ControlQ1Q2_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en la ubicacion: \n {pathSave}");
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                //para graficar
                pwm1 = controlPIDQ1.PWM;
                VariablesControl.Pwm1 = pwm1.ToString();
                labelPWM1.Text = $@" {pwm1:f2} %";

                pwm2 = controlPIDQ2.PWM;
                VariablesControl.Pwm2 = pwm2.ToString();
                labelPWM2.Text = $@" {pwm2:f2} %";

                temperatura1 = (VariablesControl.Temperatura1 != "") ? double.Parse(VariablesControl.Temperatura1.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                temperatura2 = (VariablesControl.Temperatura2 != "") ? double.Parse(VariablesControl.Temperatura2.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                corriente1 = (VariablesControl.Corriente1 != "") ? (double.Parse(VariablesControl.Corriente1.Replace(",", "."), CultureInfo.InvariantCulture)) * 1000 : 0;
                corriente2 = (VariablesControl.Corriente2 != "") ? (double.Parse(VariablesControl.Corriente2.Replace(",", "."), CultureInfo.InvariantCulture)) * 1000 : 0;

                tiempo = (VariablesControl.Tiempo != "") ? double.Parse(VariablesControl.Tiempo.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                labelTemperatureQ1.Text = $@" {temperatura1:f2} °C";
                checkBoxCurrentQ1.Text = $@" {corriente1:f2} mA";

                labelTemperaturaQ2.Text = $@" {temperatura2:f2} °C";
                checkBoxCurrentQ2.Text = $@" {corriente2:f2} mA";

                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                   
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm1);
                    VariablesControl.listaSetPoint1.Add(setPoint1);

                    VariablesControl.listaTemperatura2.Add(temperatura2);
                    VariablesControl.listaCorriente2.Add(corriente2);
                    VariablesControl.listaPWM2.Add(pwm2);
                    VariablesControl.listaSetPoint2.Add(setPoint2);

                    VariablesControl.listaTiempo.Add(tiempo);

                    setPoint1 = (comboBoxSetPointQ1.Text != "") ? double.Parse(comboBoxSetPointQ1.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;
                    setPoint2 = (comboBoxSetPointQ2.Text != "") ? double.Parse(comboBoxSetPointQ2.Text.Replace(",", "."), CultureInfo.InvariantCulture) : 0;

                    double tiempo2 = tiempo - VariablesControl.listaTiempo[0];
                    //grafica 
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

                    if (chargraficaQ1.Series.Count >= 8)
                    {
                        var series = chargraficaQ1.Series;

                        series[5].Enabled = checkBoxCurrentQ1.Checked;
                        series[7].Enabled = checkBoxCurrentQ2.Checked;

                        series[0].Points.AddXY(tiempo2, temperatura1);
                        series[1].Points.AddXY(tiempo2, temperatura2);
                        series[2].Points.AddXY(tiempo2, pwm1);
                        series[3].Points.AddXY(tiempo2, setPoint1);
                        series[4].Points.AddXY(tiempo2, setPoint2);
                        series[5].Points.AddXY(tiempo2, corriente1);
                        series[6].Points.AddXY(tiempo2, pwm2);
                        series[7].Points.AddXY(tiempo2, corriente2);
                    }

                }
                else if(tiempo < 10)
                {
                    foreach (var series in chargraficaQ1.Series)
                    {
                        series.Points.Clear();
                    }
                    VariablesControl.limpiarLista();
                }

                //encender el led
                if (double.TryParse(comboBoxTemperaturaQ1.Text, out double tempAlarma1))
                {
                    if (tempAlarma1 <= temperatura1)
                    {
                        VariablesControl.AlarmaLed1 = "on";
                        labelTemperatureQ1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        VariablesControl.AlarmaLed1 = "off";
                        labelTemperatureQ1.ForeColor = System.Drawing.Color.White;
                    }
                }
                else
                {

                    VariablesControl.AlarmaLed1 = "off";
                    labelTemperatureQ1.ForeColor = System.Drawing.Color.White;
                }

                if (double.TryParse(comboBoxTemperaturaQ2.Text, out double tempAlarma2))
                {
                    if (tempAlarma2 <= temperatura2)
                    {
                        VariablesControl.AlarmaLed2 = "on";
                        labelTemperaturaQ2.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        VariablesControl.AlarmaLed2 = "off";
                        labelTemperaturaQ2.ForeColor = System.Drawing.Color.White;
                    }
                }
                else
                {

                    VariablesControl.AlarmaLed2 = "off";
                    labelTemperaturaQ2.ForeColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                MessageBox.Show("no es un numero uno de los datos");
            }
        }
        //

    }
}
