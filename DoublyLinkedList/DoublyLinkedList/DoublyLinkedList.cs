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
                current.Next.Previous = current.Previous;
            }


            count--;
        }
        public void removeindex(int indexes)
        {

            int index = 0;
            var current = Head;

            while (index != indexes)
            {
                current = current.Next;
                index++;
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
                current.Next.Previous = current.Previous;
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
            if(current == Head)
            {
                addfirst(addvalue);

            }
            //else if (current == Tail)
            //{
            //    addlast(addvalue);

            //}
            else
            {
                DoubleNode<T> Temp = new DoubleNode<T>(addvalue);

                current.Previous.Next = Temp;
                Temp.Next = current;
                Temp.Previous = current.Previous;
                current.Previous = Temp;
            }
            
         
            
        }
        public void Displaylist()
        {
            var current = Head;
            while (current != null)
            {
               
                
                    Console.WriteLine($"{current.Value}");
                
            
                current = current.Next;
            }


        }
        public void Displaylistback()
        {
            var current = Tail;
            while (current != null)
            {


                Console.WriteLine($"{current.Value}");


                current = current.Previous;
            }


        }

    }
}
