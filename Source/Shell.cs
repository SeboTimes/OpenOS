using System;

using Sys = Cosmos.System;

using OpenOS.Source;

namespace OpenOS.Source
{
    internal class Shell
    {
        FS fs;

        public Shell()
        {
            Console.WriteLine($"\nSimpleOS v1.0: Shell Mode");
            Console.WriteLine("SeboTimes 2022\n");
        }

        public void handleInput()
        {
            try
            {
                string[] commands = { "shutdown", "reboot", "help", "clear", "fs.data", "gui", "echo.data" };

                Console.Write("SimpleOS> ");
                string shellInput = Console.ReadLine();

                if (shellInput == commands[0])
                {
                    Sys.Power.Shutdown();
                }
                else if (shellInput == commands[1])
                {
                    Sys.Power.Reboot();
                }
                else if (shellInput == commands[2])
                {
                    Console.WriteLine("Commands:");
                    foreach (string command in commands)
                    {
                        Console.WriteLine(command);
                    }
                }
                else if (shellInput == commands[3])
                {
                    Console.Clear();
                }
                else if (shellInput == commands[4])
                {
                    fs = new FS();
                }
                else if (shellInput == commands[5])
                {
                    Graphics graphics = new Graphics();
                    graphics.Draw();
                }
                else if (shellInput == commands[6])
                {
                    Console.WriteLine("IsQEMU: " + Sys.VMTools.IsQEMU.ToString());
                    Console.WriteLine("IsVirtualBox: " + Sys.VMTools.IsVirtualBox.ToString());
                    Console.WriteLine("IsVMWare: " + Sys.VMTools.IsVMWare.ToString());
                }

                else
                {
                    Console.WriteLine("Command not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine();
        }
    }
}
