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
            var current = Head;
     
            if (Head.Value.Equals(addvalue))
            {
                Head = Head.Next;

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
        public void insert(int index, T addvalue)
        {
            var current = Head;
            int currentindex = 2;
            if (index == 0)
            {
                Addfirst(addvalue);
            }
            else if (index == 1)
            {
                SingleNode<T> temp = new SingleNode<T>(addvalue);
                temp.Next = current.Next;
                current.Next= temp;

            }
            else
            {      
                while (currentindex != index )
                {
                    
                    current = current.Next;
                    currentindex++;
                }
                if (current.Next.Next != null)
                {
                    SingleNode<T> temp = new SingleNode<T>(addvalue);
                    temp.Next = current.Next;
                    current.Next = temp;
                }
                else
                {
                    
                }
            }

        }
    }
}
