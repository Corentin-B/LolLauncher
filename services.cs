using System;
using System.Media;
using System.Threading;

namespace LeagueOverwolfLauncher
{
    class Services
    {
        public static bool RunLeagueOfLegend()
        {
            PlayStartupSound();

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

        private static void PlayStartupSound()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var rand = new Random();

            int num = rand.Next(110);

            if (num <= 50)
            {
                using (var soundPlayer = new SoundPlayer(path + "Ressources\\Jhin.wav"))
                {
                    soundPlayer.Play();
                }
            }
            else if (num <= 100)
            {
                using (var soundPlayer = new SoundPlayer(path + "Ressources\\Kayn.wav"))
                {
                    soundPlayer.Play();
                }
            }
            else
            {
                using (var soundPlayer = new SoundPlayer(path + "Ressources\\Azir.wav"))
                {
                    soundPlayer.Play();
                }
            }
        }
    }
}
