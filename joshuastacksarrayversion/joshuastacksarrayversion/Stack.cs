using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuastacksarrayversion
{
    class Stack<T>
    {
        T[] stackarray= new T [4];

        int count = 0;
        public Stack()
        {
         

        }
        public void Push (T addvalue)
        {
            stackarray[count+1 ] = addvalue;
            count++;
            if(count == stackarray.Length)
            {
                T[] temp = new T[count *2];
                for (int i = 0; i < count; i++)
                {
                    stackarray[i] = temp[i];
                }
                stackarray = temp;
            }
            
           
        }
        public void Pop ()
        {
            count--;
            if ( count <= stackarray.Length/2)
            {
                T[] temp = new T[count/ 2];
                for (int i = 0; i < count; i++)
                {
                    stackarray[i] = temp[i];
                }
                stackarray = temp;
            }
        }
        public void Peek ()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{stackarray[i]}");
            }

            

        }

    }
}
