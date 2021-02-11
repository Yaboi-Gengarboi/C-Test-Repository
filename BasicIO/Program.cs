using System;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_str;
            Console.WriteLine("Input some text.");
            input_str = Console.ReadLine();
            Console.Write("You wrote: ");
            Console.WriteLine(input_str);
        }
    }
}