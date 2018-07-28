using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursionjoshua
{
    class Program
    {
        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
        static int Fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1 || num == 2)
            {
                return 1;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        static int DisplayArray( int[] numarray, int  num)
        {


            Console.WriteLine($"");
            return DisplayArray(numarray, num-1);

        }
        
            static void Main(string[] args)
        {
            int test = Fibonacci(7);
            
            


            int number = 0;
            int factorial = 1;

            Console.WriteLine("type in # ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number + 1; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"{factorial}");

            Console.ReadKey();
        }
    }
}
