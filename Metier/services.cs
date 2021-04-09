using System.Threading;

namespace LeagueOverwolfLauncher
{
    class services
    {
        public static bool RunLeagueOfLegend()
        {
            Thread.Sleep(3000);

            if (!FindProcess.IsRunning("LeagueOfLegends"))
            {
                if (!RunProcess.Run("LeagueOfLegends"))
                    return false;
            }
            return true;
        }

        public static bool RunOverwolf()
        {
            Thread.Sleep(3000);

            if (!FindProcess.IsRunning("Overwolf"))
            {
                if (!RunProcess.Run("Overwolf"))
                    return false;
            }
            return true;
        }

        public static bool WaitOverwolf()
        {
            int timeout = 0;
            while (!FindProcess.IsRunning("Overwolf") && timeout < 10)
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
