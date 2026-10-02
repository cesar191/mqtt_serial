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

        public double ErrorDouble { get; set; } = 0;
        public double[] ErrorArray { get; set; }= new double[3];
        public double[] PwmArray { get; set; }= new double[2];

        public double Kp { get; set; } = 0;
        public double Ki { get; set; } = 0;
        public double Kd { get; set; } = 0;
        public double Ts { get; set; } = 1;
        public double PWM { get; set; } = 0;

        //filtro
        private double pwmfiltro = 0;
        private double alpha = 0.7; //1 sin filtro, y 0<alpha<1

        public ControlPID(){ }

        // calculos para el %pwm dependiendo de que tipo de control sea

        public void reseteo()
        {
            ErrorArray[0] = 0;
            ErrorArray[1] = 0;
            ErrorArray[2] = 0;
            PwmArray[0] = 0;
            PwmArray[1] = 0;
            pwmfiltro = 0;
        }
        public void SystemControlP(double errorDouble, double kp)
        {
            ErrorArray[0] = errorDouble;

            PwmArray[0]=ErrorArray[0]*kp;
            validacion(PwmArray[0]);
            
        }
        public void SystemControlPI(double errorDouble, double kp, double ki, double ts)
        {
            ErrorArray[1] = ErrorArray[0];
            ErrorArray[0] = errorDouble;

            PwmArray[0] = PwmArray[1] + (kp + ki * ts) * ErrorArray[0] - kp * ErrorArray[1];
            validacion(PwmArray[0]);

            PwmArray[1] = PwmArray[0];

        }
        public void SystemControlPID(double errorDouble, double kp,double ki,double kd, double ts)
        {

            double q0 = kp +ki*ts+ (kd / ts);
            double q1 = -(kp + (2 * (kd / ts)));    
            double q2 = kd / ts;
            //control
            ErrorArray[2] = ErrorArray[1];
            ErrorArray[1] = ErrorArray[0];
            ErrorArray[0] = errorDouble;

            PwmArray[0] = PwmArray[1]+q0*ErrorArray[0]+q1*ErrorArray[1]+q2*ErrorArray[2];
            validacion(PwmArray[0]);
            //actualizar
            PwmArray[1] = PwmArray[0];
            

        }
        public void validacion(double pwmDoublef)
        {
            pwmfiltro = alpha * pwmDoublef + (1 - alpha) * pwmfiltro; 
            if (pwmfiltro > 100)
            {
                PWM = 100;
                pwmfiltro = 100;
            }
            else if (pwmfiltro < 0)
            {
                PWM = 0;
                pwmfiltro = 0;
            }
            else
            {
                PWM =Math.Round(pwmfiltro,2);
            }
            PwmArray[0] = pwmfiltro;
        }
    }



}
