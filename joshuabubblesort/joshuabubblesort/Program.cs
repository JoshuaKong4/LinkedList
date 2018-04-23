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

            sortlist.Addfirst(4);
            sortlist.Addfirst(5);
            sortlist.Addfirst(6);
            sortlist.Addfirst(7);
            sortlist.Addfirst(8);
           
           
            sortlist.View();

            sortlist.Sort();
            Console.WriteLine($"");
            sortlist.View();
            Console.ReadKey();
        }
    }
}
