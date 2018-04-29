using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuabubblesort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List sortlist = new List();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {

                sortlist.Addfirst(rand.Next(1,500));
               
            }


            sortlist.View();

            sortlist.Sort();
            Console.WriteLine($"");
            sortlist.View();
            Console.ReadKey();
        }
    }
}
