using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacklistjoshua
{
    class Stacknode<T>
    {
        public T value;
       public Stacknode<T> Next;
    public Stacknode (T VAlues)
        {
            value = VAlues;
            Next = null;
        }
    }
}
