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
            List list = new List();
            list.Addfirst(1);
            list.Addfirst(41);
            list.Display();
            Console.ReadKey();
        }
    }
}
