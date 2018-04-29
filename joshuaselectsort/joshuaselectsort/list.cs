using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuaselectsort
{
    class List
    {
        public int count = 0; 
        public int[] Array = new int[40];
        public List()
        {


        }
        public void Addfirst (int addvalue)
        {
            Array[count] = addvalue;
            count++;
        }
        public void Sort()
        {


        }
        public void Display()
        {

            for(int i = 0; i<count; i++)
            {

                Console.WriteLine($"{Array[count]}");

            }

        }
    }
}
