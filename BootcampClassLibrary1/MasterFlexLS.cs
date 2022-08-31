using System;
using System.Collections.Generic;


namespace BootcampClassLibrary1
{
    public class MasterFlexLS : PeristaliticPumpBase , iperistaliticPump

    {
        private string _hostName;
        private int _port;


        public MasterFlexLS(string hostName, int port)
        {
            _hostName = hostName;
            _port = port;
        }

        protected override void InternalStart()
        {
            //Send "Start" command to HTTp endpoint
        }

        protected override void InternalStop()
        {
            //Send "Stop" command to HTTp endpoint
        }
    }
}
