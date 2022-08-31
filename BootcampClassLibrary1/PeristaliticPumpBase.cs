using System;
using System.Configuration;

namespace BootcampClassLibrary1
{ 
   
    
        public static class PeristaliticPumpFactory
        {
            public static iperistaliticPump MakePump()    // factory method
            {
                //factory method that returns a specific pump based on the current Configuration
                string configuredPump = ConfigurationManager.AppSettings["Pump"];

                return configuredPump switch
                {
                    "Boxer25K" => new Boxer25K("COM1"),
                    "MasterFlexLS" => new MasterFlexLS("10.10.1.20", 2500),
                    _ => throw new System.Exception("Invalid pump configuartion.")
                };
            }

        }
    public abstract class PeristaliticPumpBase
    {



        private bool _isRunning;
        private int _rpm;

        public void Start()
        {
            InternalStart();
            _isRunning = true;
        }

        public void Stop()
        {
            InternalStop();
            _isRunning = false;
        }

        public bool IsRunning { get => _isRunning; }
        public int RPM
        {
            get => _rpm;

            set
            {
                _rpm = value;
            }
        }
        protected abstract void InternalStart();
        protected abstract void InternalStop();

    }
     
}
