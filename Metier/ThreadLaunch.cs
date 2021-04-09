using System;
using System.Threading;

namespace LeagueOverwolfLauncher
{
    class ThreadLaunch
    {
        private const int AUTORUN_TIMER = 3;
        private readonly MainForm mainForm = null;

        public enum Status
        {
            Check_Overwolf = 1,
            Run_Overwolf = 2,
            Waiting_Overwolf = 3,
            Overwolf_Is_running = 4,
            Run_League_Of_Legends = 5,
            All_program_running = 6
        }

        public ThreadLaunch(MainForm form)
        {
            mainForm = form;
        }

        public void RunBoth()
        {
            mainForm.UpdateVisibility();
            mainForm.UpdateLabel("Program Start", true);
            MessageAndProgressBar(Status.Check_Overwolf);

            if (FindProcess.IsRunning("Overwolf"))
            {
                MessageAndProgressBar(Status.Run_League_Of_Legends);

                Services.RunLeagueOfLegend();

                MessageAndProgressBar(Status.All_program_running);
            }
            else
            {
                MessageAndProgressBar(Status.Run_Overwolf);

                if (RunProcess.Run("Overwolf"))
                {
                    MessageAndProgressBar(Status.Waiting_Overwolf);

                    if (FindProcess.WaitOverwolf())
                    {
                        MessageAndProgressBar(Status.Overwolf_Is_running);

                        if (FindProcess.IsRunning("Overwolf"))
                        {
                            MessageAndProgressBar(Status.Run_League_Of_Legends);

                            Services.RunLeagueOfLegend();
                        }
                        MessageAndProgressBar(Status.All_program_running);
                    }
                    else
                    {
                        mainForm.UpdateLabel("Error Overwolf", false);
                    }
                }
            }
        }

        public void AutoLaunch()
        {
            int autoRunTimer = AUTORUN_TIMER;

            Thread.Sleep(1000);

            for (int i = autoRunTimer; i > 0; i--)
            {
                mainForm.UpdateLabel("AutoRun in " + i + " seconds", true);
                Thread.Sleep(1000);
            }
            RunBoth();
        }

        public void RunLeagueOfLegends()
        {
            Thread.Sleep(1000);

            mainForm.UpdateMessage("Run League Of Legends", 5);
            if (Services.RunLeagueOfLegend())
            {
                MessageAndProgressBar(Status.All_program_running);
            }
            else
            {
                mainForm.UpdateLabel("Erreur de lancement", false);
            }
        }

        public void RunOverwolf()
        {
            Thread.Sleep(1000);

            mainForm.UpdateMessage("Run Overwolf", 5);
            if (Services.RunOverwolf())
            {
                MessageAndProgressBar(Status.All_program_running);
            }
            else
            {
                mainForm.UpdateLabel("Erreur de lancement", false);
            }
        }

        public void MessageAndProgressBar(Status status)
        {
            switch (status)
            {
                case Status.Check_Overwolf:
                    mainForm.UpdateMessage("Check Overwolf", 1);
                    break;

                case Status.Run_Overwolf:
                    mainForm.UpdateMessage("Run Overwolf", 2);
                    break;

                case Status.Waiting_Overwolf:
                    mainForm.UpdateMessage("Waiting Overwolf", 3);
                    break;

                case Status.Overwolf_Is_running:
                    mainForm.UpdateMessage("Overwolf is running", 4);
                    break;

                case Status.Run_League_Of_Legends:
                    mainForm.UpdateMessage("Run League Of Legends", 5);
                    break;

                case Status.All_program_running:
                    mainForm.UpdateMessage("All program running", 6);
                    mainForm.UpdateLabel("Exit", false);
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                    break;
                default:
                    mainForm.UpdateMessage("Error", 0);
                    break;
            }
        }
    }
}
