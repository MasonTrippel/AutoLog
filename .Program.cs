using System;
using System.IO;
using System.Windows.Forms;

namespace Autolog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

        }
        static void OnProcessExit(object sender, EventArgs e)
        {

            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentAccount.txt", "\0");
        }

    }
}
