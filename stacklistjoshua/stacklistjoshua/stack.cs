using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacklistjoshua
{
    class stack<T>
    {
        stacknode<T> Head;
        public stack ()
        {
            Head = null;

        }
        public void push (T addvalue)
        {
            if(Head == null)
            {
                Head.value = addvalue;

            }
            else
            {
                var current = Head;
                while(current.Next != null)
                {
                    current.Next = new stacknode<T>(addvalue);

                }

            }
        }
        public void pop ()
        {


        } public void peek ()
        {


        }
    }
}
