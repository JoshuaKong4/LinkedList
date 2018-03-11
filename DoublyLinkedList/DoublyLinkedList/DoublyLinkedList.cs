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
        public DoubleNode<T> selected;
        int count;
      public DoublyLinkedList ()
        {
            Head = null;
            Tail = Head;
        }
        public void addfirst(T addvalue)
        {
            if (Head == null)
            {
                Head = new DoubleNode<T>(addvalue);
                Tail = Head;
                
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
                Head = Tail;
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

        public void remove (T addvalue)
        {

            var current = Head;

            while (!current.Value.Equals(addvalue))
            {
                current = current.Next;

            }

            if (current == Head)
            {
                Head = current.Next;
                current.Next.Previous = null;

            }
            else if (current == Tail)
            {
                Tail = current.Previous;
                current.Previous.Next = null;
            }
            else
            {
                current.Previous.Next = current.Next;
            }


            count--;
        }
        public void addindex(int Index, T addvalue)
        {
            int index = 0;
            var current = Head;

            while (index != Index)
            {
                current = current.Next;
                index++;
            }
            DoubleNode<T> Temp = new DoubleNode<T>(addvalue);

            Temp.Next = current;
            Temp.Previous = current.Previous.Previous;
            current.Previous.Previous.Next = Temp;
            current.Previous = Temp;
            
            

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
      

        }






    }
}
