using System;
using System.IO;
using System.Linq;

namespace Day_2a
{
    class Program
    {
        private const string InputPath = @"day2a-input.txt";

        static void Main(string[] args)
        {
            int[] code = File.ReadAllText(InputPath).Split(",").Select(int.Parse).ToArray();

            code[1] = 12;
            code[2] = 2;

            Intcode processor = new Intcode(code);
            processor.Process();
            processor.PrintValue(0);

            Console.ReadKey();
        }
    }
}
