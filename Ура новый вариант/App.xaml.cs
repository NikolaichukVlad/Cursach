using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Ура_новый_вариант
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
        }

        private static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {

            System.Diagnostics.EventLog loggggger = new System.Diagnostics.EventLog();
            loggggger.WriteEntry("Exception was found");
            System.Environment.Exit(1);
        }
    }
}
