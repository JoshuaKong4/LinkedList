using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuainsertionsort
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int count = 0;
            int sortedindex = 0;
            int insertindex = 0;
            int index1 = 0;
              
            List<int> todolist=new List<int>();
            List<int> havedonelist = new List<int>();
         
             
           for (int i = 0; i < 10; i++)
            {
                todolist.Add(11 - i);
                 
              Console.WriteLine($"{ todolist[i] }");
            }
            Console.WriteLine("");

            
        


            Console.ReadKey();

        }
     
       
    }
}
