using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
//

namespace mqtt_serial.funciones
{

    public static class VariablesControl
    {
        #region variablesControl
        //estados de prueba 
        private static bool estadoDeConexion = false;

        //topicos y serial
        public static string ClienteId { get; set; } = $"Usco_{DateTime.Now:yyyyMMdd_HHmmss}";
        public static string[] topicRecibir ={
                    "test/sensor/temperatura1",
                    "test/sensor/temperatura2",
                    "test/sensor/corrienteQ1",
                    "test/sensor/corrienteQ2",
                    "test/sensor/tiempo"
            };
        public static string[] topicEnviar ={
                    "test/datos/pwm1",
                    "test/datos/pwm2",
                    "test/datos/led1",
                    "test/datos/led2",
                    "test/datos/ventilador1",
                    "test/datos/ventilador2"
        };
       public static string RutaCertificadoCA { get; set; }
        public static string RutaCertificadoClient { get; set; }
        public static string RutaClavePrivada { get; set; }


        public static string pathSave = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DatosInterfaz\";
        //public static string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");//example 20260315_123350 

        //lista de variables para exportar a excel
        public static List<double> listaTemperatura1 = new List<double>();
        public static List<double> listaTemperatura2 = new List<double>();
        public static List<double> listaCorriente1 = new List<double>();
        public static List<double> listaCorriente2 = new List<double>();
        public static List<double> listaTiempo = new List<double>();
        public static List<double> listaPWM1 = new List<double>();
        public static List<double> listaPWM2 = new List<double>();
        public static List<double> listaSetPoint1=new List<double>();
        public static List<double> listaSetPoint2 = new List<double>();

        //exportar cambios de valores 
        public static List<double> listaTiempo2=new List<double>();
        public static List<string> PlantaControl = new List<string>();
        public static List<double> listaKp = new List<double>();
        public static List<double> listaKi = new List<double>();
        public static List<double> listaKd = new List<double>();
        public static List<double> listaTs = new List<double>();

        //convierto las variables a una propiedad manipulable para las interfaces

        public static string Temperatura1 { get; set; } = "20";
        public static string Temperatura2 { get; set; } = "20";
        public static string Corriente1 { get; set; } = "0";
        public static string Corriente2 { get; set; } = "0";
        public static string Tiempo { get; set; } = "0";


        public static string Pwm1 { get; set; } = "0";
        public static string Pwm2 { get; set; } = "0";
        public static string AlarmaLed1 { get; set; } = "off";
        public static string AlarmaLed2 { get; set; } = "off";
        public static string Ventilador1 { get; set; } = "off";
        public static string Ventilador2 { get; set; } = "off"; 


    //estados de prueba
    public static bool EstadoDeConexion { get { return estadoDeConexion; } set { estadoDeConexion = value; } }

        #endregion
    public static void reseteoParametros()
        {
    
         Pwm1 = "0";
         Pwm2 = "0";
         AlarmaLed1 = "off";
         AlarmaLed2 = "off";
         Ventilador1 = "off";
         Ventilador2 = "off";
        }
    public static void limpiarLista()
        {
            //parametros de grafica
            listaTiempo.Clear(); 

            listaTemperatura1.Clear();
            listaTemperatura2.Clear();

            listaCorriente1.Clear();
            listaCorriente2.Clear();

            listaPWM1.Clear();
            listaPWM2.Clear();

            listaSetPoint1.Clear();
            listaSetPoint2.Clear();
            
            //parametros de control
            listaKd.Clear();
            listaKp.Clear();
            listaKi.Clear();
            listaTs.Clear();

            listaTiempo2.Clear();
            PlantaControl.Clear();
        }
        
    }
    
}
