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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace mqtt_serial.ventanas
{
    public partial class control_Q1 : Form
    {
        #region VariablesDeControl
        private ControlPID controlPID = new ControlPID();

        private double kp = 0;
        private double ki = 0;
        private double kd = 0;
        private double ts = 0;
        private double setPoint = 0;
        private string errorString;
        private double errorDouble = 0;
        #endregion

        private double temperatura1;
        //private string temperatura2;
        private double corriente1;
        private double tiempo;
        private double pwm;
        

        private string pathSave = VariablesControl.pathSave + @"ControlQ1\";




        private void SystemControl(double errorDouble, double kp, double ki, double kd, double ts)
        {
            ts = (ts != 0) ? (ts) : (0.1);
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
            else
            {
                
            }

            VariablesControl.Pwm1 = controlPID.PWM.ToString();
        }

        public control_Q1()
        {
            InitializeComponent();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)

        {

            double.TryParse(comboBoxKp.Text.Replace('.', ','), out kp);
            double.TryParse(comboBoxKi.Text.Replace('.', ','), out ki);
            double.TryParse(comboBoxKd.Text.Replace('.', ','), out kd);
            double.TryParse(comboBoxTs.Text.Replace('.', ','), out ts);

            for (int i = 0; i < controlPID.ErrorArray.Length; i++)
            {
                controlPID.ErrorArray[i] = 0;
            }
            for (int i = 0; i < controlPID.PwmArray.Length; i++)
            {
                controlPID.PwmArray[i] = 0;
            }

            VariablesControl.listaTiempo2.Add(tiempo);
            VariablesControl.listaKp.Add(kp);
            VariablesControl.listaKi.Add(ki);
            VariablesControl.listaKd.Add(kd);
            VariablesControl.listaTs.Add(ts);

        }

        private void control_Q1_Load(object sender, EventArgs e)
        {
            comboBoxSetPoint.Text = "0";

            comboBoxKp.Text = "0";
            comboBoxKi.Text = "0";
            comboBoxKd.Text = "0";
            comboBoxTs.Text = "0";

            VariablesControl.limpiarLista();
            VariablesControl.reseteoParametros();

            Directory.CreateDirectory(pathSave);
            timer1.Enabled = true;

        }

        private void control_Q1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                //para graficar
                pwm = controlPID.PWM;
                temperatura1 = double.Parse(VariablesControl.Temperatura1.Replace('.', ','));
                corriente1 = (double.Parse(VariablesControl.Corriente1.Replace('.', ','))) * 1000;
                tiempo = double.Parse(VariablesControl.Tiempo.Replace('.', ','));


                labelTemperature.Text = " " + temperatura1 + " °C";
                checkBoxCurrent.Text = " " + corriente1 + " mA";


                double.TryParse(comboBoxSetPoint.Text, out setPoint);

                errorDouble = setPoint - temperatura1;
                errorString = errorDouble.ToString();
                SystemControl(errorDouble, kp, ki, kd, ts);

                //
                graficarCorrienteToolStripMenuItem.Checked = checkBoxCurrent.Checked;
                if (checkBoxCurrent.Checked)
                {
                    
                    this.chargraficaQ1.Series[1].Enabled = true;
                }
                else
                {
                    this.chargraficaQ1.Series[1].Enabled = false;
                }



                if (tiempo > 10 && VariablesControl.EstadoDeConexion)
                {
                    // this.chargraficaQ1.Series[1].Enabled = false;
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Maximum = corriente1 + 0.5;
                    //this.chargraficaQ1.ChartAreas[1].AxisY.Minimum = corriente1 - 0.5;

                    //
                    VariablesControl.listaTemperatura1.Add(temperatura1);
                    VariablesControl.listaCorriente1.Add(corriente1);
                    VariablesControl.listaPWM1.Add(pwm);
                    VariablesControl.listaTiempo.Add(tiempo);
                    VariablesControl.listaSetPoint1.Add(setPoint);

                    //this.chargraficaQ1.ChartAreas[2].AxisY.Minimum = VariablesControl.listaTemperatura1.Min()-10;
                    //int axisGraficaX = 600;
                    //if (tiempo - VariablesControl.listaTiempo[0] > axisGraficaX)
                    //{
                    //    this.chargraficaQ1.ChartAreas[0].AxisX.Minimum = tiempo - axisGraficaX;
                    //    this.chargraficaQ1.ChartAreas[1].AxisX.Minimum = tiempo - axisGraficaX;
                    //}

                    //

                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[0].Points.AddXY(tiempo, temperatura1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[2].Points.AddXY(tiempo, pwm)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[1].Points.AddXY(tiempo, corriente1)));
                    this.chargraficaQ1.Invoke((MethodInvoker)(() => chargraficaQ1.Series[3].Points.AddXY(tiempo, setPoint)));
                }
                else if (tiempo < 10)
                {
                    this.chargraficaQ1.Series[0].Points.Clear();
                    this.chargraficaQ1.Series[1].Points.Clear();
                    this.chargraficaQ1.Series[2].Points.Clear();
                    this.chargraficaQ1.Series[3].Points.Clear();    

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
            catch
            {
                //MessageBox.Show("no es un numero uno de los datos");
            }

        }

        private void buttonVentilador_Click(object sender, EventArgs e)
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
                    this.chargraficaQ1.SaveImage($@"{pathSave}Grafica_ControlQ1_{fecha}.png", System.Drawing.Imaging.ImageFormat.Png);
                    SLDocument document = new SLDocument();
                    
                    //lista de titulos del excel
                    document.SetCellValue(1, 1, "Tiempo");
                    document.SetCellValue(1, 2, "Temperatura1");
                    document.SetCellValue(1, 3, "Corriente1");
                    document.SetCellValue(1, 4, "PWM1");
                    document.SetCellValue(1, 5, "SetPoint");

                    document.SetCellValue(1, 7,  "Kp");
                    document.SetCellValue(1, 8, "Ki");
                    document.SetCellValue(1, 9, "Kd");
                    document.SetCellValue(1, 10, "Ts");
                    document.SetCellValue(1, 11, "Cambio (s)");

                    for (int i = 0; i < VariablesControl.listaTiempo.Count; i++)
                    {
                        document.SetCellValue(i + 2, 1, VariablesControl.listaTiempo[i]);
                        document.SetCellValue(i + 2, 2, VariablesControl.listaTemperatura1[i]);
                        document.SetCellValue(i + 2, 3, VariablesControl.listaCorriente1[i]);
                        document.SetCellValue(i + 2, 4, VariablesControl.listaPWM1[i]);
                        document.SetCellValue(i + 2, 5, VariablesControl.listaSetPoint1[i]);
                    }
                    for(int i = 0; i < VariablesControl.listaTiempo2.Count; i++)
                    {
                        document.SetCellValue(i + 2, 7, VariablesControl.listaKp[i]);
                        document.SetCellValue(i + 2, 8, VariablesControl.listaKi[i]);
                        document.SetCellValue(i + 2, 9, VariablesControl.listaKd[i]);
                        document.SetCellValue(i + 2, 10, VariablesControl.listaTs[i]);
                        document.SetCellValue(i + 2, 11, VariablesControl.listaTiempo2[i]);

                    }
                    SLPicture imagenGrafica = new SLPicture($@"{pathSave}Grafica_ControlQ1_{fecha}.png");
                    imagenGrafica.SetPosition(1, 14);
                    document.InsertPicture(imagenGrafica);

                    document.SaveAs($@"{pathSave}DatosGrafica_ControlQ1_{fecha}.xlsx");
                }
                timer1.Start();
                MessageBox.Show($"Se exporto los datos en la ubicacion: \n {pathSave}");
            }
            catch
            {

            }
        }

        private void graficarCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graficarCorrienteToolStripMenuItem.Checked = !checkBoxCurrent.Checked;
            checkBoxCurrent.Checked = graficarCorrienteToolStripMenuItem.Checked;
        }

        private void chargraficaQ1_Click(object sender, EventArgs e)
        {

        }
    }
}
