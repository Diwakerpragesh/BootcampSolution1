using BootcampClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{


    public class Xyz : PeristaliticPumpBase, iperistaliticPump

    {
        private string _McName;



        public Xyz(string McName)
        {
            _McName = McName;
            
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
