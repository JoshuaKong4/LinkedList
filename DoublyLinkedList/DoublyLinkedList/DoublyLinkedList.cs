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
        public DoubleNode<T> Tail;
        int count;
      public DoublyLinkedList ()
        {
            Head = null;
            Tail = null;
        }
        public void addfirst(T addvalue)
        {
            if (Head == null)
            {
                Head = new DoubleNode<T>(addvalue);
                Tail = Head.Next;
                count++;
            }
           
            else
            {
                DoubleNode<T> Temp = new DoubleNode<T>(addvalue);
                Temp.Next = Head;
                Head.Previous = Temp;
                Head = Temp;
                count++;
                
            }

        }
        public void addlast(T addvalue)
        {

            if (Tail == null)
            {

                Tail = new DoubleNode<T>(addvalue);
            }
            else
            {
                DoubleNode<T> Temp = new DoubleNode<T>(addvalue);
                Temp.Previous = Tail;
                Tail.Next = Temp;
                Tail = Temp;
                count++;
            }
               
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current.Next != null)
            {
                yield return current.Value;
         
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
                while (!addvalue.Equals(current.Value))
                {
                    current.Previous = current.Next;

                }
               

            }
            count--;
        }
        public void displaylist()
        {
            var current = Head;
            while (current != null)
            {
                if (current == Head)
                {
                    Console.WriteLine($"H{current.Value}");
                }
                else if (current == Tail)
                {
                    Console.WriteLine($"T{current.Value}");
                }
                else
                {
                    Console.WriteLine($"{current.Value}");

                }
                current = current.Next;
            }
          //'  Console.WriteLine($"count:{count}");

        }
        public void displaybackwards()
        {
            var current = Tail;
            while (current != null)
            {
                if (current == Head)
                {
                    Console.WriteLine($"H{current.Value}");
                }
                else if (current == Tail)
                {
                    Console.WriteLine($"T{current.Value}");
                }
                else
                {
                    Console.WriteLine($"{current.Value}");

                }
                current = current.Previous;
            }
         //   Console.WriteLine($"count:{count}");

        }






    }
}
