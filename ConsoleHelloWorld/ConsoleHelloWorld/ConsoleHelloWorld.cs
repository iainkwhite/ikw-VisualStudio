using System;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello, Julie! ";
            string b = " ";
            Console.WriteLine(a);
            Console.WriteLine(b);
            string c = Console.ReadLine();
            Console.WriteLine("You typed: " + c);
        }
    }
}