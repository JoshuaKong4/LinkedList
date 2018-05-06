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
            for(int i = 0; i< 5; i++)
            {
               
                list.Addfirst(rand.Next(1,10));
            }
            list.Display();

            for (int i = 0; i < 1; i++)
            {
                list.Sort();
               
            }
            Console.WriteLine("");
            list.Display();
            Console.ReadKey();
        }
    }
}
