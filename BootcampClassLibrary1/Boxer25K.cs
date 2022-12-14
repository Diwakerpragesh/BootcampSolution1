 using System;
using System.Runtime.CompilerServices;

namespace BootcampClassLibrary1
{
    public class Boxer25K : PeristaliticPumpBase , iperistaliticPump
    {
        private string _comPort;

        public Boxer25K(string comPort)
        {
            _comPort = comPort; 
        }
        protected override void InternalStart()
        {
            // send an "S" command over a COM  Port
            System.Threading.Thread.Sleep(3000);
            throw new System.Exception("Unable to start pump after trying for 3 seconds");
        }
        protected override void InternalStop()
        {
            // send an "H" command over a COM  Port
        }
    }
}
