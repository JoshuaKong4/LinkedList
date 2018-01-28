using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlylinkedlistjoshua
{
    class SingleNode<T>
    {
        public T Value;
        public SingleNode<T> Next = null;
        public SingleNode(T item)
         {
            Value = item;

         }
    }
}
