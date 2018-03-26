using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuastacksarrayversion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Stack<int> lol = new Stack<int>();

            lol.Push(1);
            lol.Push(2);
            lol.Push(3);
            lol.Peek();
            Console.ReadKey();
        }
    }
}
