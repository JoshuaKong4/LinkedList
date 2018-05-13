using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuaselectsort
{
    class Program
    {
       static void Main(string[] args)
        {
            Random rand = new Random();
            List list = new List();
            for(int i = 0; i< 4; i++)
            {
               
                list.Addfirst(rand.Next(1,10));
            }
            list.Display();

            for (int i = 0; i < list. count; i++)
            {
                list.Sort();
                Console.WriteLine("");
                list.Display();

            }
           

            Console.ReadKey();
        }
    }
}
