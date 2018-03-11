using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            
           for(int i = 0; i<10; i++)
            {
               
                list.addfirst(i);
                         

            }
           
           list.addindex(5, 21);

            list.displaylist();
            //list.displaybackwards();
        
            //foreach (int currentNumber in list)
            //{
            //   // Console.WriteLine(currentNumber);
            //}

            Console.ReadKey();
        }
    }
}
