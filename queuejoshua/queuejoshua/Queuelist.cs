using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuejoshua
{
    class Queuelist<T>
    {
        public Node<T> Head;

        public Queuelist ()
        {
            Head = null;

        }
        public void Queue(T addvalue)
        {
            if (Head == null)
            {
                Head = new Node<T>(addvalue);

            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {

                    current = current.Next;
                }
                current.Next = new Node<T>(addvalue);
            }

        }
        public void Dequeue()
        {
            Head = Head.Next;

        }
        public void View ()
        {
          
            var current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Value}");
                current = current.Next;
                
            }
        

        }
    }
}
