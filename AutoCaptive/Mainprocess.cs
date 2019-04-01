using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCaptive
{
    public class Mainprocess
    {
        public static void AppExit()
        {
            foreach (Process proc in Process.GetProcessesByName("AutoCaptiveBase"))
            {
                proc.Kill();
            }
            Application.Exit();
        }

        public static void AppStop()
        {
            foreach (Process proc in Process.GetProcessesByName("AutoCaptiveBase"))
            {
                proc.Kill();
            }

            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName("AutoCaptive");
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    process.Kill();
                }
            }

            current.Kill();
        }

        public static void callBase()
        {
            // First kill if any instance is running
            foreach (Process proc in Process.GetProcessesByName("AutoCaptiveBase"))
            {
                proc.Kill();
                proc.WaitForExit();
            }
            ProcessStartInfo startinfo = new ProcessStartInfo("AutoCaptiveBase.exe");
            var prc = Process.Start(startinfo);
        }
    }
}
