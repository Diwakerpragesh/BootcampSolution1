using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{
    public interface iperistaliticPump
    {
        public bool IsRunning { get; }
        public int RPM { get; set; }

        public void Start();
        public void Stop();

    }
}
