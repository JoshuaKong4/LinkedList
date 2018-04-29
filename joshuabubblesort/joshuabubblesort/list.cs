using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuabubblesort
{
    class List
    {
        public Node Head;
        int count;
        public List()
        {
            Head = null;

        }
        public void Addfirst(int addvalue)
        {
            if(Head == null)
            {
                Head = new Node(addvalue);
                count++;
            }
            else
            {
                Node temp = new Node (addvalue);
                temp.Next = Head;
                Head = temp;
                count++;
            }
            
        }
        public void Sort()
        {
            var current = Head;
            for (int i = 0; i < count; i++)
            {
                while (current.Next != null)
            {

                if (current.Value > current.Next.Value)
                {
                    int temp = current.Next.Value;
                    current.Next.Value = current.Value;
                    current.Value = temp;
                }

                current = current.Next;

            }
            current = Head;
        
         }
              
                   
         
                

       


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
