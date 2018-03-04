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
            //list.addlast(1);
            //list.addlast(2);
            //list.addlast(3);
            //list.addlast(4);
            //list.addlast(5);
            //list.addlast(6);
            //list.addlast(7);
            //list.addlast(8);
            //list.addlast(9);
           for(int i = 0; i<10; i++)
            {
               
                list.addfirst(i);
                         

            }
           // list.remove(5);

           list.displaylist();
            list.displaybackwards();
        
            foreach (int currentNumber in list)
            {
               // Console.WriteLine(currentNumber);
            }

            Console.ReadKey();
        }
    }
}
