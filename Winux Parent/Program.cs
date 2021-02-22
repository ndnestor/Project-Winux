using System;
using System.Diagnostics;

namespace Winux_Parent {
    class Program {

        private static Process[] explorerProcesses = Process.GetProcessesByName("explorer");

        static void Main(string[] args) {
            StripWindows();

            Console.ReadLine();
        }

        //Remove windows features
        private static void StripWindows() {
            //Kill Windows Explorer >:)
            if(explorerProcesses.Length == 1) {
                explorerProcesses[0].Kill();
                Console.WriteLine("Killed Windows Explorer");
            } else {
                Console.WriteLine("Found " + explorerProcesses.Length + " explorer processes");
                foreach(Process process in Process.GetProcesses()) {
                    Console.WriteLine(process.ProcessName);
                }
            }
        }
    }
}
