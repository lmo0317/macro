using System;
using System.Runtime.InteropServices;

namespace LastWarMacro.Script
{
    public class KeyboardInput
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        // Virtual Key Codes 및 Flags
        private const byte VK_ESCAPE = 0x1B; // ESC 키
        private const uint KEYEVENTF_KEYUP = 0x0002; // 키 뗌

        public static void SendEsc()
        {
            // ESC 키 누름
            keybd_event(VK_ESCAPE, 0, 0, UIntPtr.Zero);
            // ESC 키 뗌
            keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }
    }
}
