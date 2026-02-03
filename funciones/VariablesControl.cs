using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace mqtt_serial.funciones
{
    
    public static class  VariablesControl
    {
        #region variablesControl
        //datos recibidos
        private static string temperatura1;
        private static string temperatura2;
        private static string corriente1;
        private static string corriente2;
        private static string tiempo;
        //datos a enviar
        private static string pwm1;
        private static string pwm2;
        private static string alarmaLed1;
        private static string alarmaLed2;
        private static string ventilador1;
        private static string ventilador2;
        
        //convierto las variables a una propiedad manipulable para las interfaces
        
        public static string Temperatura1 { get { return temperatura1; } set { temperatura1 = value; } }
        public static string Temperatura2 { get { return temperatura2; } set { temperatura2 = value; } }
        public static string Corriente1 { get { return corriente1; } set { corriente1 = value; } }
        public static string Corriente2 { get { return corriente2; } set { corriente2 = value; } }
        public static string Tiempo { get { return tiempo; } set { tiempo = value; } }
        


        public static string Pwm1 {  get { return pwm1; } set { pwm1 = value; } } 
        public static string Pwm2 { get { return pwm2; } set { pwm2 = value; } }
        public static string AlarmaLed1 { get {return alarmaLed1; } set { alarmaLed1 = value; } }
        public static string AlarmaLed2 { get {return alarmaLed2; } set { alarmaLed2 = value; } }
        public static string Ventilador1 { get { return ventilador1; } set { ventilador1 = value; } }
        public static string Ventilador2 { get { return ventilador2; } set { ventilador2 = value; } }
        
        #endregion
    }
    
}
