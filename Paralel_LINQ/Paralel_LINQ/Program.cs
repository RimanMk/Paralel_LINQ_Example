using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralel_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            var factorials = from n in numbers.AsParallel().AsOrdered()
                             where n > 0
                             select Factorial(n);
            foreach (var n in factorials)
                Console.WriteLine(n);

            Console.Read();
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
