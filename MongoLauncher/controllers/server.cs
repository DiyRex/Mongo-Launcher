using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoLauncher.controllers
{
    internal class server
    {
        private static Process mongoProcess;
        //start Server
        public static void StartServer(string dbpath, bool isAuth, string port)
        {
            try
            {
                // Specify the MongoDB path and arguments
                string mongoPath = "mongod.exe";
                string arguments;
                if (isAuth)
                {
                    arguments = $"--dbpath={dbpath} --auth --port={port}";
                }
                else
                {
                    arguments = $"--dbpath={dbpath} --port={port}";
                }


                // Create a new process to start the MongoDB server
                mongoProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = mongoPath,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                // Event handler for capturing output (optional)
                mongoProcess.OutputDataReceived += (s, args) => Console.WriteLine(args.Data);
                mongoProcess.ErrorDataReceived += (s, args) => Console.WriteLine(args.Data);

                // Start the process
                mongoProcess.Start();
                mongoProcess.BeginOutputReadLine();
                mongoProcess.BeginErrorReadLine();
                Launcher.mongoState = true;
            }
            catch (Exception)
            {
                //
            }
        }

        //start server from path
        public static void StartServer(string path, string dbpath, bool isAuth, string port)
        {
            try
            {
                // Specify the MongoDB path and arguments
                string mongoPath = $"{path}/mongod.exe";
                string arguments;
                if (isAuth)
                {
                    arguments = $"--dbpath={dbpath} --auth --port={port}";
                }
                else
                {
                    arguments = $"--dbpath={dbpath} --port={port}";
                }


                // Create a new process to start the MongoDB server
                mongoProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = mongoPath,
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                // Event handler for capturing output (optional)
                mongoProcess.OutputDataReceived += (s, args) => Console.WriteLine(args.Data);
                mongoProcess.ErrorDataReceived += (s, args) => Console.WriteLine(args.Data);

                // Start the process
                mongoProcess.Start();
                mongoProcess.BeginOutputReadLine();
                mongoProcess.BeginErrorReadLine();
                Launcher.mongoState = true;
            }
            catch (Exception)
            {
                //
            }
        }

        //Kill mongod instances
        public static void KillMongoServer()
        {
            try
            {
                // Get all processes named "mongod.exe"
                Process[] mongodProcesses = Process.GetProcessesByName("mongod");

                // Kill each process
                foreach (Process process in mongodProcesses)
                {
                    process.Kill();
                    process.WaitForExit();
                    process.Dispose();
                }
                Launcher.mongoState = false;
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
