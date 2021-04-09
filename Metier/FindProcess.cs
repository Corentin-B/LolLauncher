using System.Diagnostics;
using System.Threading;

namespace LeagueOverwolfLauncher
{
    class FindProcess
    {
        public static bool IsRunning(string program)
        {
            Process[] listprocess = Process.GetProcessesByName(program);

            if (listprocess.Length != 0)
                return true;
            else
                return false;
        }

        public static bool WaitOverwolf()
        {
            int timeout = 0;
            while (!IsRunning("Overwolf") && timeout < 10)
            {
                Thread.Sleep(3000);
                timeout++;
            }

            if (timeout < 10)
                return true;
            else
                return false;
        }
    }
}
