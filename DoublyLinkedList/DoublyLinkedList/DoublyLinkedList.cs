using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T>
    {
       public DoubleNode<T> Head;
      public DoublyLinkedList ()
        {
            Head = null;
           
        }
        public void addfirst(T addvalue)
        {
            if (Head == null)
            {
                Head =  new DoubleNode<T>(addvalue);

            }
            else
            {
                DoubleNode<T> Temp = new DoubleNode<T>(addvalue);
                Temp.Next = Head;
                Temp.Previous = Head;
                Head = Temp;
                
            }

        }
        public void addlast(T addvalue)
        { 
          
            if (Head == null)
            {

                addfirst(addvalue);
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = new DoubleNode<T>(addvalue);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current.Next != null)
            {
                yield return current.Value;
             // current = current.Next;
            }
        }

        public void remove (T addvalue)
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
        public void displaylist()
        {
            var current = Head;
            while (current.Previous != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }

        }






    }
}
