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
            List<int> list = new List<int>();
            for(int i = 0; i< 5; i++)
            {

                list.Add(rand.Next(0, 50));
                Console.WriteLine(list[i]);

                count++;
            }
            Console.WriteLine("");

            for (int i = 0; i < 1; i++)
            {
                int sortedindex = 0;
                int insertindex = 0;
                int lowest = 0;
                bool issorted = true;
                for (int j = sortedindex; j < count; j++)
                {
                    if (list[i] < list[lowest])
                    {

                        lowest = i;
                       // Console.WriteLine($"{j}");
                     
                    }
                    if(list[lowest] < list[0])
                    {
                        insertindex = lowest;

                    }
                    else
                    {

                        issorted = true; 
                    }
                    
                }
                sortedindex++;
                if (issorted == false)
                {
                    list[0] = list[insertindex];
                    for (int j = 1; j < insertindex; j++)
                    {
                        list[j] = list[j-1];

                    }
                }

            }
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"{list[i]}");
            }



                Console.ReadKey();

        }
       
    }
}
