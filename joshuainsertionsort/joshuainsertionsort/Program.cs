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

                list.Add(rand.Next(0, 50));
                Console.WriteLine(list[i]);

                count++;
            }
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {

               // int insert= list[sortedindex +1];
                
                for (int j = count  ; j >1 ; j --)
                {
                    //list[j -1]= list[j];
                    list[7] = 0;
                }

                //if (list[sortedindex] > list[sortedindex + 1])
                //{
                   
                //    list[0] = insert;
                
                                    

                //}
               
                
                for (int j = 0; j < count; j++)
                {
                    //if (j == sortedindex)
                    //{
                    //    Console.WriteLine($"{list[j]}sorted");
                    //}
                    //else
                    //{
                        Console.WriteLine($"{list[j]}");

                   // }
                }
                Console.WriteLine("");
                sortedindex++;
            }
           



                Console.ReadKey();

        }
       
    }
}
