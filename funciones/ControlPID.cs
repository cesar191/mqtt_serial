using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial.funciones
{
    public class ControlPID
    {
        private string errorString;
        private string kp;
        private string ki;
        private string kd;
        private string ts;
        private string pwm;

        private double[] errorDouble = new double[3];

        private double kpDouble;
        private double kiDouble;
        private double kdDouble;
        private double tsDouble;
        private double[] pwmDouble=new double[2];



        public string Kp {get { return kp;}set { kp = value; }}
		public string Ki {get {return ki;} set {ki = value;}}
        public string Kd {get {return kd;} set {kd = value;}}
        public string Ts {get {return ts;} set {ts = value;}}
        public string ErrorString {get {return errorString;} set {errorString = value;}} 
        public string PWM { get {return pwm;} set {pwm = value;}}

        public ControlPID()
        {
            pwm = "0";
        }

        // calculos para el %pwm dependiendo de que tipo de control sea
        public ControlPID(string error, string kp, string ts)
        {
            bool validaciondatos = double.TryParse(kp, out kpDouble) &&
                                  double.TryParse(error, out errorDouble[0]) &&
                                  double.TryParse(ts, out tsDouble);
            if (validaciondatos){

                pwmDouble[0]=errorDouble[0]*kpDouble;

                if (pwmDouble[0] > 100)
                {
                    pwm = "100";
                }
                else if (pwmDouble[0] < 0)
                {
                    pwm = "0";
                }
                else
                {
                    pwm = pwmDouble[0].ToString();
                }

            }
            else
            {
               // MessageBox.Show("uno de los valores no es un numero");
            }

        }
        public ControlPID(string error,string kp, string ki, string ts)
        {
            bool validaciondatos = double.TryParse(kp, out kpDouble)&& 
                                   double.TryParse(ki, out kiDouble)&&
                                   double.TryParse(error, out errorDouble[0])&&
                                   double.TryParse(ts, out tsDouble);
            if (validaciondatos)
            {
                
            }
            else
            {
                MessageBox.Show("uno de los valores no es un numero");
            }
        }
        public ControlPID(string error,string kp, string ki,string kd, string ts)
        {
            bool validaciondatos = double.TryParse(kp, out kpDouble)&& 
                                   double.TryParse(ki, out kiDouble)&& 
                                   double.TryParse(kd, out kdDouble)&& 
                                   double.TryParse(error, out errorDouble[0])&& 
                                   double.TryParse(ts, out tsDouble);
            if (validaciondatos)
            {
                double q0 = (kpDouble + (kdDouble / tsDouble));
                double q1 = (-kpDouble + kiDouble * tsDouble - (2 * (kdDouble / tsDouble)));
                double q2 = (kdDouble / tsDouble);
                pwmDouble[0] = pwmDouble[1]+q0*errorDouble[0]+q1*errorDouble[1]+q2*errorDouble[2];
                pwmDouble[1] = pwmDouble[0];
                errorDouble[2] = errorDouble[1];
                errorDouble[1]= errorDouble[0];

                if(pwmDouble[0] > 100)
                {
                    pwm = "100";
                }
                else if (pwmDouble[0] < 0)
                {
                    pwm = "0";
                }
                else
                {
                    pwm = pwmDouble[0].ToString();
                }

            }
            
            else
            {
                MessageBox.Show("uno de los valores no es un numero");
            }
        }
        
    }



}
	
