using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuainsertionsort
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int count = 0;
            int sortedindex = 0;

            List<int> list = new List<int>();
            for(int i = 0; i< 8; i++)
            {

                list.Add(8-i);
                Console.WriteLine(list[i]);
                
                count++;
            }
            Console.WriteLine("");

            for (int i = 0; i < count-1; i++)
            {

                int temp = list[count-1];

                for (int j = count-1; j > 0; j--)
                {

                    list[j] = list[j - 1];
                }
                list[0] = temp;





                for (int j = 0; j < count; j++)
                {
                    if (j == sortedindex)
                    {
                        Console.WriteLine($"{j} {list[j]}sorted");
                    }
                 
                    else
                    {

                        Console.WriteLine($"{j} {list[j]}");
                    }
                   


                }
                Console.WriteLine($"");
                //  Console.WriteLine("");
                sortedindex++;
            }
           



                Console.ReadKey();

        }
       
    }
}
