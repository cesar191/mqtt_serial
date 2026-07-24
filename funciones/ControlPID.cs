using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_serial.funciones
{
    public class ControlPID
    {
        private double errorDouble = 0;
        private double kp = 0;
        private double ki = 0;
        private double kd = 0;
        private double ts = 0;
        private double pwm = 0;

        private double[] errorArray = new double[3];
        private double[] pwmArray = new double[2];


        //datos recibidos y enviados desde la ventana
        public double Kp { get { return kp; } set { kp = value; } }
        public double Ki { get { return ki; } set { ki = value; } }
        public double Kd { get { return kd; } set { kd = value; } }
        public double Ts { get { return ts; } set { ts = value; } }
        public double ErrorDouble { get { return errorDouble; } set { errorDouble = value; } }
        public double PWM { get { return pwm; } set { pwm = value; } }
        
        //verificacion de actualizacion de valores

        public double[] ErrorArray { get { return errorArray; } set { errorArray = value; } }
        public double[] PwmArray { get { return pwmArray; } set { pwmArray = value; } }

        public ControlPID()
        {
            pwm = 0;
        }

        // calculos para el %pwm dependiendo de que tipo de control sea
        public void SystemControlP(double errorDouble, double kp)
        {

            errorArray[0] = errorDouble;
            pwmArray[0]=errorArray[0]*kp;
            validacion(pwmArray[0]);

            

        }
        public void SystemControlPI(double errorDouble, double kp, double ki, double ts)
        {
            pwmArray[1] = pwmArray[0];
            errorArray[1] = errorArray[0];
            //
            errorArray[0] = errorDouble;
            pwmArray[0] = pwmArray[1] + (kp + ki * ts) * errorArray[0] - kp * errorArray[1];
            
            
            validacion(pwmArray[0]);


        }
        public void SystemControlPID(double errorDouble,double kp,double ki,double kd, double ts)
        {
          
            double q0 = (kp +ki*ts+ (kd / ts));
            double q1 = (-kp - (2 * (kd / ts)));    
            double q2 = (kd / ts);
            //actualizar
            pwmArray[1] = pwmArray[0];
            errorArray[2] = errorArray[1];
            errorArray[1] = errorArray[0];
            //control
            errorArray[0] = errorDouble;
            pwmArray[0] = pwmArray[1]+q0*errorArray[0]+q1*errorArray[1]+q2*errorArray[2];
                
            validacion(pwmArray[0]);



        }
        public void validacion(double pwmDoublef)
        {
            if (pwmDoublef > 100)
            {
                pwm = 100;
                
            }
            else if (pwmDoublef < 0)
            {
                pwm = 0;
            }
            else
            {
                pwm = pwmDoublef;
            }
            pwmArray[0] = pwm;
        }
    }



}
	
