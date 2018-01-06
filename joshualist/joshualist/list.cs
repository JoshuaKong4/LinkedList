using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshualist
{
    class list
    {
        int[] mylist;

        public list()
        {
            mylist = new int[0];
        }

        public void Add(int num)
        {
            int[] temparr = new int[mylist.Length + 1];

            for (int i = 0; i < mylist.Length; i++)
            {
                temparr[i] = mylist[i];
            }

            temparr[temparr.Length - 1] = num;

            mylist = temparr;
        }

        public void Remove(int num)
        {
            int[] shortarr = new int[mylist.Length - 1];
    
            bool found = false;
            for (int i = 0; i < mylist.Length; i++)
            {
                if(num == mylist[i])
                {
                   
                        for (int j = 0; j < shortarr.Length; j++)
                        {
                            if (j < i)
                            {
                                shortarr[j] = mylist[i];

                            }
                            if (j > i)
                            {
                                shortarr[j] = mylist[i + 1];
                            }
                        mylist = shortarr;
                            found = true;
                        }
                    
                            
                         

                }
            }

        }
    }
}
