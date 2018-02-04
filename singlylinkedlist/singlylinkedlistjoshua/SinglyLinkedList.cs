using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlylinkedlistjoshua
{
    class SinglyLinkedList<T>
    {
        SingleNode<T> Head;
        public SinglyLinkedList()
        {
            Head = null;
        }
        public void Addfirst(T addvalue)
        {
            if (Head == null)
            {
                Head = new SingleNode<T>(addvalue);

            }
            else
            {
                SingleNode<T> temp = new SingleNode<T>(addvalue);
                temp.Next = Head;
                Head = temp;
            }

        }

        public void DisplayList()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Value.ToString()}");

                current = current.Next;
            }

        }
        public void Addlast(T addvalue)
        {
            if (Head == null)
            {
                Addfirst(addvalue);
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = new SingleNode<T>(addvalue);
                           
            }

        }
        public void Remove (T addvalue)
        {
            var current = Head.Next;
     
            if (Head.Next.Value.Equals(addvalue))
            {
           
            }
           else
            {
                while (!addvalue.Equals(current.Next.Value))
                {
                    current = current.Next;

                }
                if (current.Next.Next != null)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current.Next = null;
                }
                        
           }
        }
    }
}
