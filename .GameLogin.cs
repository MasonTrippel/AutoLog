using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Autolog
{
    class GameLogin
    {
        public void login(string acc, bool CheckState)
        {
            LOLUC lol = new LOLUC();

            string db = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt");

            if (File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt") == "val")
            {
                List<string> list = lol.SqlData(acc, db);

                if (!CheckState)
                {
                    Process.Start("C:\\Riot Games\\Riot Client\\RiotClientServices.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{ENTER}");
                    Thread.Sleep(2000);
                    SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
                    Thread.Sleep(1000);
                    SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
                }
                else
                {
                    Process.Start("C:\\Riot Games\\Riot Client\\RiotClientServices.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{TAB}{TAB}{TAB}{TAB}{ENTER}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
                    Thread.Sleep(2000);
                    SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
                    Thread.Sleep(1000);
                    SendKeys.Send("{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");

                }
            }
            else if (File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt") == "lol")
            {
                List<string> list = lol.SqlData(acc, db);
                if (!CheckState)
                {
                    Process.Start("C:\\Riot Games\\League of Legends\\LeagueClient.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{ENTER}");
                    Thread.Sleep(15000);
                    Process[] task = Process.GetProcesses();
                    List<string> procs = new List<string>();
                    foreach (Process proc in task)
                    {

                        if (proc.ToString() == "System.Diagnostics.Process (RiotClientUx)")
                        {
                            proc.Kill();
                            break;
                        }
                    }


                }
                else
                {
                    Process.Start("C:\\Riot Games\\League of Legends\\LeagueClient.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{TAB}{TAB}{TAB}{TAB}{ENTER}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{ENTER}");
                    Thread.Sleep(15000);
                    Process[] task = Process.GetProcesses();
                    List<string> procs = new List<string>();
                    foreach (Process proc in task)
                    {

                        if (proc.ToString() == "System.Diagnostics.Process (RiotClientUx)")
                        {
                            proc.Kill();
                        }
                    }
                }
            }
            else if (File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt") == "r6")
            {
                List<string> list = lol.SqlData(acc, db);
                if (!CheckState)
                {
                    Process.Start("C:\\Program Files (x86)\\Ubisoft\\Ubisoft Game Launcher\\UbisoftConnect.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{ENTER}");

                }
                else
                {
                    Process.Start("C:\\Riot Games\\League of Legends\\LeagueClient.exe");
                    Thread.Sleep(7000);
                    SendKeys.Send(list[0] + "{TAB}" + list[1] + "{TAB}{ENTER}");


                }
            }
        }
    }
}
