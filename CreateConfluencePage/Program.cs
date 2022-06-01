using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace CreateConfluencePage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.Sleep(6000);
            var logDerictory =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ConfluencePageCreator\\Logs\\");
            Directory.CreateDirectory(logDerictory);
            Log.Logger = new LoggerConfiguration()
               .WriteTo.File(logDerictory+"logs.txt", shared: true, rollingInterval: RollingInterval.Day)
               .CreateLogger();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
