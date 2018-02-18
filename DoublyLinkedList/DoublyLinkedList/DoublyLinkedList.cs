using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T>
    {
        DoubleNode<T> Head;
      public DoublyLinkedList ()
        {
            Head = null;
           
        }
        public void addfirst(T addvalue)
        {
            if (Head == null)
            {
                Head.Value = addvalue;

            }
            else
            {
                DoubleNode<T> Temp = new DoubleNode<T>(addvalue);
                Temp.Next = Head;
                Temp = Head;
            }

        }
        public void addlast(T addvalue)
        {

            

            var current = Head;
            if (Head == null)
            {

                Head.Value = addvalue;
            }
            else
            {
                while(current != null)
                {
                    current = current.Next;

                }
                current.Next = new DoubleNode<T>(addvalue);
            }
        }
        public void remove (T removevalue)
        {


        }



        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current.Next != null)
            {
                yield return current.Value;
            }
        }


    }
}
