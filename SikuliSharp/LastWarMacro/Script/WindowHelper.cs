using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LastWarMacro.Script
{
    public class WindowHelper
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static bool FocusProcess(string processName)
        {
            var procs = Process.GetProcessesByName(processName);
            if (procs.Length == 0)
                return false;

            return SetForegroundWindow(procs[0].MainWindowHandle);
        }
    }
}
