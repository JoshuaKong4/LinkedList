using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuaselectsort
{
    class List
    {
        int smallestindex = 0;
        int sortedindex = 0;
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
            for (int i = sortedindex; i < count; i++)
            {
                if (Array[i] < Array[smallestindex])
                {
                    smallestindex = i;
                    
                }
            
            }
            int temp = Array[smallestindex];
            Array[smallestindex] = Array[sortedindex];
            Array[sortedindex]  = temp;
           
            
            sortedindex++;
           smallestindex = sortedindex;
           

        }
        public void Display()
        {

            for(int i = 0; i<count; i++)
            {
                if (i == sortedindex)
                {
                    Console.WriteLine($"{Array[i]}sorted");

                }
                else if(i== smallestindex)
                {
                    Console.WriteLine($"{Array[i]} smallest");
                    
                }
                else
                {
                Console.WriteLine($"{Array[i]}");


                }

            }
         
        }
    }
}
