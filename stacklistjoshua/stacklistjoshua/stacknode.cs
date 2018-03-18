using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacklistjoshua
{
    class stacknode<T>
    {
        public T value;
       public stacknode<T> Next;
    public stacknode (T VAlues)
        {
            value = VAlues;
            Next = null;
        }
    }
}
