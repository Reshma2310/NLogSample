using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generic
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        double[] percent = { 1.2, 2.3, 22.6, 50.7, 0.85 };
        Char[] Alphabets = { 'R', 'E', 'S', 'D' };

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
