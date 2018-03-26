using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacklistjoshua
{
    class Stack<T>
    {
        Stacknode<T> Head;
        public Stack ()
        {
            Head = null;

        }
        public void Push (T addvalue)
        {
            if(Head == null)
            {
                Head = new Stacknode<T>(addvalue);

            }
            else
            {
                var current = Head;
                while(current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = new Stacknode<T>(addvalue);

            }
        }
        public void Pop ()
        {
            if (Head != null)
            {
                var current = Head;
                if (current.Next == null)
                {

                    Head = null;
                }
                else
                {
                    while (current.Next.Next != null)
                    {
                        current = current.Next;

                    }
                    current.Next = null;
                }
            }

        }
        public void Peek ()
        {
            var current = Head;
            if (Head != null)
            {
                while (current.Next != null)
                {

                    current = current.Next;

                }
                Console.WriteLine($"{current.value}");
            }
        }
    }
}
