using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuejoshua
{
    class Node<T>
    {
       public Node<T> Next;
       public T Value;
        public Node( T value)
        {
            Next = null;
            Value = value;
        }
    }
}
