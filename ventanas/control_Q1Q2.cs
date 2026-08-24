using mqtt_serial.funciones;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private double temperatura1, temperatura2, corriente1, corriente2, tiempo;

        private double pwm1, pwm2, setPoint1 = 0, setPoint2 = 0, errorDouble1 = 0, errorDouble2 = 0;
        private double kp1 = 0, kp2 = 0, ki1 = 0, ki2 = 0, kd1 = 0, kd2 = 0, ts1 = 0, ts2 = 0;

        private void buttoActualizarQ2_Click(object sender, EventArgs e)
        {
            controlActulizar.Titulo = "Parametros Control Q2";
            controlActulizar.ShowDialog();

            kp2 = controlActulizar.Kp;
            ki2 = controlActulizar.Ki;
            kd2 = controlActulizar.Kd;
            ts2 = controlActulizar.Ts;

            labelControlQ2.Text = $@"KP= {kp2}{Environment.NewLine}Ki= {ki2}{Environment.NewLine}Kd= {kd2}{Environment.NewLine}T= {ts2}";
            for (int i = 0; i < controlPIDQ2.ErrorArray.Length; i++)
            {
                controlPIDQ2.ErrorArray[i] = 0;
            }
            for (int i = 0; i < controlPIDQ2.PwmArray.Length; i++)
            {
                controlPIDQ2.PwmArray[i] = 0;
            }

            //para exportar al exce
            VariablesControl.listaKp.Add(kp2);
            VariablesControl.listaKi.Add(ki2);
            VariablesControl.listaKd.Add(kd2);
            VariablesControl.listaTs.Add(ts2);
            VariablesControl.listaTiempo2.Add(tiempo);
            VariablesControl.PlantaControl.Add("Q2");

        }

        private void buttonActulizarQ1_Click(object sender, EventArgs e)
        {
            controlActulizar.Titulo = "Parametros Control Q1";
            controlActulizar.ShowDialog();
            
            kp1 = controlActulizar.Kp;
            ki1 = controlActulizar.Ki;
            kd1 = controlActulizar.Kd;
            ts1 = controlActulizar.Ts;

            labelControlQ1.Text =$@"KP= {kp1}{Environment.NewLine}Ki= {ki1}{Environment.NewLine}Kd= {kd1}{Environment.NewLine}T= {ts1}";

            for (int i = 0; i < controlPIDQ1.ErrorArray.Length; i++)
            {
                controlPIDQ1.ErrorArray[i] = 0;
            }
            for (int i = 0; i < controlPIDQ1.PwmArray.Length; i++)
            {
                controlPIDQ1.PwmArray[i] = 0;
            }

            //para exportar al excel
            VariablesControl.listaKp.Add(kp1);
            VariablesControl.listaKi.Add(ki1);
            VariablesControl.listaKd.Add(kd1);
            VariablesControl.listaTs.Add(ts1);
            VariablesControl.listaTiempo2.Add(tiempo);
            VariablesControl.PlantaControl.Add("Q1");
        }

        ControlActual controlActulizar = new ControlActual();

        private ControlPID controlPIDQ1 = new ControlPID();
        private ControlPID controlPIDQ2 = new ControlPID();
        #endregion

        private string pathSave = VariablesControl.pathSave + @"ControlQ1Q2\";

        private void SystemControl(double errorDouble, double kp, double ki, double kd, double ts, ControlPID control)
        {
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

        public control_Q1Q2()
        {
            InitializeComponent();
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

        private void control_Q1Q2_Load(object sender, EventArgs e)
        {
            comboBoxSetPointQ1.Text = "0";

            VariablesControl.limpiarLista();
            VariablesControl.reseteoParametros();

            Directory.CreateDirectory(pathSave);
            timer1.Enabled = true;
        }

        private void control_Q1Q2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
        //private void graficarCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
            // {
            // graficarCorrienteToolStripMenuItem.Checked = !checkBoxCurrentQ1.Checked;
           // checkBoxCurrentQ1.Checked = graficarCorrienteToolStripMenuItem.Checked;
            //   checkBoxCurrentQ2.Checked = checkBoxCurrentQ1.Checked;
            // }

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
                    this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_ControlQ1Q2_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);

                    SLDocument document = new SLDocument();
                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    document.SetCellValue(1, 5, "SetPoint1");

                    document.SetCellValue(1, 6, "Temperatura2");
                    document.SetCellValue(1, 7, "Corriente2");
                    document.SetCellValue(1, 8, "PWM1");
                    document.SetCellValue(1, 9, "SetPoint2");

                    document.SetCellValue(1, 12, "Kp");
                    document.SetCellValue(1, 13, "Ki");
                    document.SetCellValue(1, 14, "Kd");
                    document.SetCellValue(1, 15, "Ts");
                    document.SetCellValue(1, 16, "Cambio (s)");
                    document.SetCellValue(1, 17, "Planta");
                    

                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i]);
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
                        document.SetCellValue(i + 2, 12, VariablesControl.listaKp[i]);
                        document.SetCellValue(i + 2, 13, VariablesControl.listaKi[i]);
                        document.SetCellValue(i + 2, 14, VariablesControl.listaKd[i]);
                        document.SetCellValue(i + 2, 15, VariablesControl.listaTs[i]);
                        document.SetCellValue(i + 2, 16, VariablesControl.listaTiempo2[i]);
                        document.SetCellValue(i + 2, 17, VariablesControl.PlantaControl[i]);
                        
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
                

                temperatura1 = double.Parse(VariablesControl.Temperatura1.Replace('.', ','));
                corriente1 = (double.Parse(VariablesControl.Corriente1.Replace('.', ','))) * 1000;

                pwm2 = controlPIDQ2.PWM;
                VariablesControl.Pwm2 = pwm2.ToString();

                temperatura2 = double.Parse(VariablesControl.Temperatura2.Replace('.', ','));
                corriente2 = (double.Parse(VariablesControl.Corriente2.Replace('.', ','))) * 1000;

                tiempo = double.Parse(VariablesControl.Tiempo.Replace('.', ','));


                labelTemperatureQ1.Text = " " + temperatura1 + " °C";
                checkBoxCurrentQ1.Text = " " + corriente1 + " mA";

                labelTemperaturaQ2.Text = " " + temperatura2 + " °C";
                checkBoxCurrentQ2.Text = " " + corriente2 + " mA";



                double.TryParse(comboBoxSetPointQ1.Text, out setPoint1);
                errorDouble1 = setPoint1 - temperatura1;
                //errorString1 = errorDouble1.ToString();
                SystemControl(errorDouble1, kp1, ki1, kd1, ts1, controlPIDQ1);

                double.TryParse(comboBoxSetPointQ2.Text, out setPoint2);
                errorDouble2 = setPoint2 - temperatura2;
                //errorString1 = errorDouble1.ToString();
                SystemControl(errorDouble2, kp2, ki2, kd2, ts2, controlPIDQ2);

                //
                //graficarCorrienteToolStripMenuItem.Checked = checkBoxCurrentQ1.Checked;
                if (checkBoxCurrentQ1.Checked)
                {

                    this.chargraficaQ1.Series[5].Enabled = true;
                }
                else
                {
                    this.chargraficaQ1.Series[5].Enabled = false;
                }

                
                if (checkBoxCurrentQ2.Checked)
                {

                    this.chargraficaQ1.Series[7].Enabled = true;
                }
                else
                {
                    this.chargraficaQ1.Series[7].Enabled = false;
                }



                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    // this.chargraficaQ1.Series[1].Enabled = false;
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;

                    //
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm1);
                    VariablesControl.listaSetPoint1.Add(setPoint1);

                    VariablesControl.listaTemperatura2.Add(temperatura2);
                    VariablesControl.listaCorriente2.Add(corriente2);
                    VariablesControl.listaPWM2.Add(pwm2);
                    VariablesControl.listaSetPoint2.Add(setPoint2);

                    VariablesControl.listaTiempo.Add(tiempo);


                    //this.chargraficaQ1.ChartAreas[2].AxisY.Minimum = VariablesControl.listaTemperatura1.Min()-10;
                    //int axisGraficaX = 600;
                    //if (tiempo - VariablesControl.listaTiempo[0] > axisGraficaX)
                    //  {
                    //      this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo - axisGraficaX;
                    //      this.chargraficaQ1.ChartAreas[1].AxisX.Minimum = tiempo - axisGraficaX;
                    //  }

                    //

                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, temperatura2)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, pwm1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[3].Points.AddXY(tiempo, setPoint1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[4].Points.AddXY(tiempo, setPoint2)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[5].Points.AddXY(tiempo, corriente1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[6].Points.AddXY(tiempo, pwm2)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[7].Points.AddXY(tiempo, corriente2)));
                }
                else if(tiempo < 10)
                {
                    this.chargraficaQ1.Series[0].Points.Clear();
                    this.chargraficaQ1.Series[1].Points.Clear();
                    this.chargraficaQ1.Series[2].Points.Clear();
                    this.chargraficaQ1.Series[3].Points.Clear();
                    this.chargraficaQ1.Series[4].Points.Clear();
                    this.chargraficaQ1.Series[5].Points.Clear();
                    this.chargraficaQ1.Series[6].Points.Clear();
                    this.chargraficaQ1.Series[7].Points.Clear();

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
                    labelTemperatureQ1.ForeColor = System.Drawing.Color.White;
                }


            }
            catch
            {
                //MessageBox.Show("no es un numero uno de los datos");
            }
        }


    }
}
