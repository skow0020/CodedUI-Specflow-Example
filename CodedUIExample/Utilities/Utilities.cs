using System;
using System.Diagnostics;

namespace CodedUIExample
{
    public static class UtilityMethods
    {
        public static void Launch()
        {
            
            Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        public static void Close()
        {
            foreach (var process in Process.GetProcessesByName("Calculator"))
            {
                process.Kill();
            }
        }

        public static string dateMMDDYYYY = DateTime.Now.ToString("MMddyyyy");
    }
}


