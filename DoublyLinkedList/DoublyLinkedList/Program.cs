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

            //for (int i = 0; i < 20; i++)
            //{
            //    list.addlast(i);
            //}

            list.addfirst(3);
            list.addfirst(2);
            list.addfirst(1);

            list.addlast(4);
            list.addlast(6);

            list.addindex(4, 5);

            list.addindex(0, 100);

            list.removeindex(2);
            list.Displaylist();

            list.Displaylistback();

            Console.ReadKey();
        }
    }
}
