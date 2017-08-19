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
            
            // wait for Enter
            Console.ReadLine();
            MessageBox.Show("All done");


            return 0;
        }
    }
}
