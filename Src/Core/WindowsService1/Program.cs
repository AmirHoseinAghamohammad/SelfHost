using System;
using System.ServiceProcess;
using System.Threading;

namespace WindowsService1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
        private static WebApiHostService _service;

        static void Main()
        {
            if (Environment.UserInteractive)
            {
                Console.CancelKeyPress += (sender, e) =>
                {
                    e.Cancel = true;
                    _shutdownEvent.Set();
                };


                using (var service = new WebApiHostService())
                {
                    service.PublicOnStart(new string[0]); // ارسال آرایه خالی
                    Console.WriteLine("Service running... Press ENTER to stop");
                    _shutdownEvent.WaitOne();
                    service.PublicOnStop();
                    _service.PublicOnStop();
                    _service.Dispose();
                }

                //_service = new WebApiHostService();
                //_service.PublicOnStart(null);
                //Console.WriteLine("Service running... Press CTRL+C to stop");

                //_shutdownEvent.WaitOne();

                //_service.PublicOnStop();
                //_service.Dispose();
            }
            else
            {
                ServiceBase.Run(new WebApiHostService());
            }
        }
    }
}
