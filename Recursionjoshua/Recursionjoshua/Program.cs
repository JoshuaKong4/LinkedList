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

            if (num == 0)
            {
                return numarray[0];
            }
               // Console.WriteLine($"{numarray[num]}");
                return DisplayArray(numarray, num - 1);
            

        }
        static int stringpair (string pairstring, int num , int count)
        {
            if (num + 2 == pairstring.Length)
            {

                return count;
            }
            if (pairstring[num] == pairstring[num+2])
            {
                return stringpair(pairstring, num + 1, count+1);

            }
            
            return stringpair(pairstring, num+1, count);

        }
        
            static void Main(string[] args)
        {
            int test = Fibonacci(7);
            int[] array = new int[6];
            


            int number = 0;
            int factorial = 1;
            string teststring = "axaxa";

           int pairnum =  stringpair(teststring, 0,0);
            Console.WriteLine($"{pairnum}");
            //Console.WriteLine("type in # ");
            //number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < 6; i++)
            {
                array[i] = i;
            }
            DisplayArray(array, 5);
          //  Console.WriteLine($"{factorial}");

            Console.ReadKey();
        }
    }
}
