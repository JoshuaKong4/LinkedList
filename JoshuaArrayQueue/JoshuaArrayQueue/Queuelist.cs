using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaArrayQueue
{
    class Queuelist<T>
    {
        Node<T> Head;
        T[] queuearray = new T[4];
        int count = 0;
        public Queuelist()
        {

            Head = null;

        }
        public void Enqueue (T addvalue)
        {
            queuearray[count] = addvalue;
            count++;
            if(count >= queuearray.Length)
            {
                T[] temp = new T[queuearray.Length *2];
                for(int i =0;i< queuearray.Length; i++)
                {

                    temp[i] = queuearray[i];
                }
                queuearray = temp;
            }


        }
        public void Dequeue()
        {
            for (int i = 1; i < count; i++)
            {

                queuearray[i-1] = queuearray[i];
            }
            count--;
            if (count <= queuearray.Length/2)
            {
                T[] temp = new T[count];
                for (int i = 0; i < count ; i++)
                {

                    temp[i] = queuearray[i];
                }
                queuearray = temp;
            }

        }
        public void View()
        {
            for (int i = 0; i < count ; i++)
            {

                Console.WriteLine($"{queuearray[i]}");
            }

        }
    }
}
