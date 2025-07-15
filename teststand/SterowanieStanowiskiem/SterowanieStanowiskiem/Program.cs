using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SterowanieStanowiskiem
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Pokaż splash screen
            SplashScreen splash = new SplashScreen();
            splash.Show();
            Application.DoEvents(); // wymuś wyświetlenie

            // 2. Poczekaj kilka sekund
            System.Threading.Thread.Sleep(1000); // 3 sekundy

            // 3. Zamknij splash i uruchom główną aplikację
            splash.Close();
            Application.Run(new MainWindow());
        }
    }
}
