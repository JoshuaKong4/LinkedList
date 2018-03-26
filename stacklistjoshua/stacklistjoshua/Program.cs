using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacklistjoshua
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stack<int> stacks = new Stack<int>() ;
            stacks.Push(7);
            stacks.Push(6);
            stacks.Peek();
            stacks.Pop();
            stacks.Peek();
   
            

            
            Console.ReadKey();
        }
    }
}
