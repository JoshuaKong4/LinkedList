using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoubleNode<T>
    {
        public DoubleNode<T> Next;
      public DoubleNode<T> Previous ;
        public T Value;
        public DoubleNode  (T value)
        {
            Value = value;
            Next = null;
            Previous = null;
            

        }
    }
}
