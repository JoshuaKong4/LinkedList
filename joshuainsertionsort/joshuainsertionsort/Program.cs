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
            for(int i = 0; i< 50; i++)
            {

                list.Add(rand.Next(0, 50));

                count++;
            }
            for (int i = 0; i < count; i++)
            {
                int sortedindex = 0;
                int insertindex = 0;
                for (int j = 0; j < sortedindex +1; j++)
                {
                    if(list[sortedindex +1] < list[j] )
                    {

                        insertindex = j - 1;

                    }

                }
                //      sortedindex++;
                for (int j = insertindex; j < sortedindex; j++)
                {
                    list[i + 1] = list[i];
                    list[insertindex] = list[sortedindex + 1];
                }

            }




            Console.ReadKey();

        }
    }
}
