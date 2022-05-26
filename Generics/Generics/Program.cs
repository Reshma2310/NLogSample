using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Generics Program Started");
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            double[] percent = { 1.2, 2.3, 22.6, 50.7, 0.85 };
            Char[] Alphabets = { 'R', 'E', 'S', 'D' };

            Program.toPrint<int>(numbers);
            Program.toPrint<double>(percent);
            Program.toPrint<char>(Alphabets);
        }
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
    }
}