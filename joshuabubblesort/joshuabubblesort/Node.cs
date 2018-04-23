using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuabubblesort
{
    class Node
    {
        public int Value;
        public Node Next;
   
        public Node (int value)
        {
            Value = value;
            Next = null;
        }
    }
}
