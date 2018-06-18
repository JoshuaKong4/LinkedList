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
            int insertindex = 0;
            bool sort = false;
         
     
            int[] Array = new int[10]; 
                

            for (int i = 0; i < 10; i++)
            {

                Array[i] = rand.Next(1, 30);
                Console.WriteLine($"{Array[i]}");
                count++;
            }
            Console.WriteLine("");

            for (int i = 0; i < count - 1; i++)
            {
                if (Array[sortedindex] > Array[sortedindex + 1])
                {
                    sort = true;




                }

               

                for (int j = 0; j < count - 1; j++)
                {


                  Console.WriteLine($"{Array[j]}");
                }
                Console.WriteLine($"");
               
                sortedindex++;
            }
          
             void swap(int upper, int lower)
            {


            }

         


            Console.ReadKey();

        }
        
       
    }
}
