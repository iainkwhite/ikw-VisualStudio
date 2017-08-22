using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {
            // Set up console UI
            Console.Title = "Julie console";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to my console app");
            Console.BackgroundColor = ConsoleColor.Black;

            // Get arguments using System.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);
                
            // Helper method within the Program class.
            ShowEnvironmentDetails();

            // wait for Enter
            Console.ReadLine();
            MessageBox.Show("All done");
            return 0;
        }
        private static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",
              Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}",
              Environment.Version);
        }
    }
}