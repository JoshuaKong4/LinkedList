using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlylinkedlistjoshua
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.Addfirst(7);
            list.Addfirst(6);
            list.Addfirst(5);
            list.Addfirst(4); 
            list.Addfirst(3);
            list.Addfirst(2);
            list.Addfirst(1);
            list.Remove(1);
            list.DisplayList();
            Console.ReadKey();
            













        }
    }
}
