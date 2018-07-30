using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuamergesort
{
    class Program
    {
        static List<int> Sort(List<int> list)
        {
            if (list.Count < 2)
            {
                return list;
            }


            int split = list.Count / 2;
            List<int> temp1 = new List<int>();
            List<int> temp2 = new List<int>();
            for(int i = 0; i< split; i++)
            {



            }
            temp1 = Sort(temp1);
            temp2 = Sort(temp2);

            List<int> output = merge(temp1, temp2);

            return output;
        }

        static List<int> merge(List<int> list, List<int> list2)
        {

            List<int> merged = new List<int>();
            return list;


        }
        static void Main(string[] args)
        {
        }
    }
}
