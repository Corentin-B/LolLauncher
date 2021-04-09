using System;
using System.Diagnostics;

namespace LeagueOverwolfLauncher
{
    class RunProcess
    {
        const string OVERWOLF = @"C:\Program Files (x86)\Overwolf\OverwolfLauncher.exe";
        const string OVERWOLF_PARAM = " -launchapp pibhbkkgefgheeglaeemkkfjlhidhcedalapdggh";
        const string LEAGUEOFLEGEND = @"C:\Riot Games\League of Legends\LeagueClient.exe";

        public static bool Run(string program)
        {
            try
            {
                if (program.Equals("Overwolf"))
                {
                    RunOverWolf(OVERWOLF);
                }
                else if (program.Equals("LeagueOfLegends"))
                {
                    RunLeagueOfLegend(LEAGUEOFLEGEND);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private static void RunLeagueOfLegend(string programPath)
        {
            Process process = new Process();
            process.StartInfo.FileName = programPath;
            process.Start();
        }

        private static void RunOverWolf(string programPath)
        {
            Process.Start(programPath, OVERWOLF_PARAM);
        }
    }
}
