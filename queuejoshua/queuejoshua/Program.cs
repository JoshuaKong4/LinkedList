﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuejoshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Queuelist<int> list = new Queuelist<int>();

            list.Queue(1);
            list.Queue(9);
            list.Queue(8);
            list.Queue(7);
            list.Queue(6);
            list.Queue(5);
            list.Dequeue();
            list.Dequeue();
            //list.Delete();
            //list.Delete();

            list.View();
            Console.ReadKey();
        }
    }
}
