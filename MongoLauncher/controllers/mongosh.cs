using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MongoLauncher.controllers
{
    
    internal class mongosh
    {
        public static void RunMongoshCommand(string port)
        {
            try
            {
                // Specify the command to run
                string command = $"mongosh --port={port}";

                // Start the cmd process
                Process cmdProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/K {command}", // Use "/K" to keep the CMD window open after command execution
                        UseShellExecute = false,
                        CreateNoWindow = false
                    }
                };

                // Start the process
                cmdProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running mongosh command: {ex.Message}");
            }
        }
        public static void RunMongoshCommand(string path, string port)
        {
            try
            {
                // Specify the command to run
                string command = $"{path}/mongosh --port={port}";

                // Start the cmd process
                Process cmdProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/K {command}", // Use "/K" to keep the CMD window open after command execution
                        UseShellExecute = false,
                        CreateNoWindow = false
                    }
                };

                // Start the process
                cmdProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running mongosh command: {ex.Message}");
            }
        }
    }
}

