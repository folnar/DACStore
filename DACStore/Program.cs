using System.ServiceProcess;

namespace DACStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new DACStore()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
