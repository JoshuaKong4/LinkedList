using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuainsertionsort
{
    class Node
    {
        int Value;
        Node Next;
        Node Previous; 
        public Node(int value)
        {
            Value = value;
            Next = null;
            Previous = null;

        }

    }
}
