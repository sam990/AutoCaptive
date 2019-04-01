using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCaptive
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static Mutex mutex = null;

        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length == 1 && args[0] == "--stop")
            {
                Mainprocess.AppStop();
            }
            else if (args.Length == 1 && args[0] == "--configure")
            {
                Application.Run(new Configure_AC());
            }

            /*const string appName = "AutoCaptive";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            { 
                return;
            }*/
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName("AutoCaptive");
            foreach (Process process in processes)
            { 
                if (process.Id != current.Id)
                {
                    process.Kill();
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
