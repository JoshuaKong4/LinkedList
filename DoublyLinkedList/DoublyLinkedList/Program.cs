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
            list.addfirst(1);
            list.addfirst(2);
            list.addfirst(3);         
            list.displaylist();
            foreach (int currentNumber in list)
            {
               // Console.WriteLine(currentNumber);
            }

            Console.ReadKey();
        }
    }
}
