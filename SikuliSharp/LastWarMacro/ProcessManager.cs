using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LastWarMacro
{
    public class ProcessManager
    {

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        const uint SWP_NOZORDER = 0x0004;
        const uint SWP_NOACTIVATE = 0x0010;
        const int SW_RESTORE = 9;

        private static readonly object _lock = new object();
        private static ProcessManager _instance;

        private ProcessManager()
        {

        }

        // 전역 인스턴스 접근자
        public static ProcessManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new ProcessManager();
                }
            }
        }

        public void SetWindowPos()
        {
            Process[] procs = Process.GetProcessesByName("LastWar");

            if (procs.Length > 0)
            {
                IntPtr hWnd = procs[0].MainWindowHandle;

                if (hWnd != IntPtr.Zero && IsWindowVisible(hWnd))
                {
                    // 해상도 1920x1080 기준
                    int screenWidth = 1920 - 100;
                    int screenHeight = 1080 - 100;

                    ShowWindow(hWnd, SW_RESTORE);
                    SetWindowPos(hWnd, IntPtr.Zero, 0, 0, screenWidth, screenHeight, SWP_NOZORDER | SWP_NOACTIVATE);
                    SetForegroundWindow(hWnd);
                    Console.WriteLine("위치 및 사이즈 변경 완료");
                }
                else
                {
                    Console.WriteLine("윈도우 핸들이 없거나 보이지 않는 상태");
                }
            }
            else
            {
                Console.WriteLine("해당 프로세스를 찾을 수 없습니다.");
            }
        }
    }
}
