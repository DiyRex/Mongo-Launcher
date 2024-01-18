using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MongoLauncher.controllers
{
    internal class verification
    {
        public static bool checkMongodVersionfromPath(string path)
        {
            string command = $"{path}/mongod --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = "\"version\": \"(\\d+\\.\\d+\\.\\d+)\"";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return true;
                }
                else
                {   
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool checkMongoshVersionfromPath(string path)
        {
            string command = $"{path}/mongosh --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = @"\b\d+\.\d+\.\d+\b";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetMongoDVersion()
        {
            string command = "mongod --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = "\"version\": \"(\\d+\\.\\d+\\.\\d+)\"";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    Console.WriteLine("Failed to retrieve MongoDB version.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running command: {ex.Message}");
                return null;
            }
        }
        public static string GetMongoSHVersion()
        {
            string command = "mongosh --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = @"\b\d+\.\d+\.\d+\b";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return match.Value;
                }
                else
                {
                    
                    return null;
                }
            }
            catch (Exception)
            {
                
                return null;
            }
        }


        public static string GetMongoDVersionfromPath(string path)
        {
            string command = $"{path}/mongod --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = "\"version\": \"(\\d+\\.\\d+\\.\\d+)\"";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    Console.WriteLine("Failed to retrieve MongoDB version.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running command: {ex.Message}");
                return null;
            }
        }
        public static string GetMongoSHVersionfrompath(string path)
        {
            string command = $"{path}/mongosh --version";
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    },
                    EnableRaisingEvents = true
                };

                string output = "";
                process.OutputDataReceived += (s, e) => output += e.Data + Environment.NewLine;

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();

                string versionPattern = @"\b\d+\.\d+\.\d+\b";
                Regex regex = new Regex(versionPattern);
                Match match = regex.Match(output);

                if (match.Success)
                {
                    return match.Value;
                }
                else
                {

                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}

