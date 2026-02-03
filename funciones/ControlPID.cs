using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace mqtt_serial.funciones
{
    
    internal class ControlPID
    {
		private string kp;
		private string ki;

		public string Kp
		{
			get { return kp; }
			set { kp = value; }
		}
		public string Ki
		{
			get { return ki; }
			set { ki = value; }
		}
        ControlPID(string kp, string ki)
        {

        }
        ControlPID(string kp, string ki,string kd)
        {

        }
        ControlPID(string kp)
        {

        }
    }



}
	
