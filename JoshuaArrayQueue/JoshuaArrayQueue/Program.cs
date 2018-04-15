using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaArrayQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queuelist<int> list = new Queuelist<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            list.Enqueue(4);
            list.Enqueue(5);


            list.Dequeue();
            list.Dequeue();
            list.Dequeue();
            




            list.View();

            Console.ReadKey();


            
            
        }
    }
}
