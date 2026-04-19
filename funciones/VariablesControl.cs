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

    public static class VariablesControl
    {
        #region variablesControl
        //datos recibidos
        private static string temperatura1 = "0";
        private static string temperatura2 = "0";
        private static string corriente1 = "0";
        private static string corriente2 = "0";
        private static string tiempo = "0";
        //datos a enviar
        private static string pwm1 = "0";
        private static string pwm2 = "0";
        private static string alarmaLed1 = "0";
        private static string alarmaLed2 = "0";
        private static string ventilador1 = "0";
        private static string ventilador2 = "0";
        //estados de prueba y lista de datos
        private static bool estadoDeConexion = false;

        public static string pathSave = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DatosInterfaz\";
        //public static string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");//example 20260315_123350 


        public static List<double> listaTemperatura1 = new List<double>();
        public static List<double> listaTemperatura2 = new List<double>();
        public static List<double> listaCorriente1 = new List<double>();
        public static List<double> listaCorriente2 = new List<double>();
        public static List<double> listaTiempo = new List<double>();
        public static List<double> listaPWM1 = new List<double>();
        public static List<double> listaPWM2 = new List<double>();
        public static List<double> listaSetPoint1=new List<double>();
        public static List<double> listaSetPoint2 = new List<double>();


        //convierto las variables a una propiedad manipulable para las interfaces

        public static string Temperatura1 { get { return temperatura1; } set { temperatura1 = value; } }
        public static string Temperatura2 { get { return temperatura2; } set { temperatura2 = value; } }
        public static string Corriente1 { get { return corriente1; } set { corriente1 = value; } }
        public static string Corriente2 { get { return corriente2; } set { corriente2 = value; } }
        public static string Tiempo { get { return tiempo; } set { tiempo = value; } }





        public static string Pwm1 { get { return pwm1; } set { pwm1 = value; } }
        public static string Pwm2 { get { return pwm2; } set { pwm2 = value; } }
        public static string AlarmaLed1 { get { return alarmaLed1; } set { alarmaLed1 = value; } }
        public static string AlarmaLed2 { get { return alarmaLed2; } set { alarmaLed2 = value; } }
        public static string Ventilador1 { get { return ventilador1; } set { ventilador1 = value; } }
        public static string Ventilador2 { get { return ventilador2; } set { ventilador2 = value; } }


        //estados de prueba
        public static bool EstadoDeConexion { get { return estadoDeConexion; } set { estadoDeConexion = value; } }

        #endregion

        public static void limpiarLista()
        {
            listaTiempo.Clear(); 

            listaTemperatura1.Clear();
            listaTemperatura2.Clear();

            listaCorriente1.Clear();
            listaCorriente2.Clear();

            listaPWM1.Clear();
            listaPWM2.Clear();

            listaSetPoint1.Clear();
            listaSetPoint2.Clear();
        }
        
    }
    
}
