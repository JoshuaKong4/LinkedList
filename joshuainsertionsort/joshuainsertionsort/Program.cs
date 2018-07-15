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

            List<int> todolist = new List<int>();
            List<int> havedonelist = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                todolist.Add(rand.Next(1, 1000));

                // Console.WriteLine($"{ todolist[i] }");
            }
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
     
                if (todolist[sortedindex ] <= todolist[sortedindex+1])
                {
                    int index = 0;
                    int temp = todolist[sortedindex+1];
                    todolist.RemoveAt(sortedindex+1);
                    for (int j = 0; j < havedonelist.Count; j++)
                    {

                        index = j;
                        if (havedonelist[j] < temp)
                        {
                            break;

                        }



                    }
                    havedonelist.Insert(index, temp);

                }
                else
                {
                    int index = havedonelist.Count;
                    int temp = todolist[sortedindex ];
                    todolist.RemoveAt(sortedindex );

                    havedonelist.Insert(index, temp);

                }





                for (int j = 0; j < havedonelist.Count; j++)
                {
                    Console.WriteLine($"{ havedonelist[j]}");

                }
                Console.WriteLine($"{ todolist[0]}sorted");
                for (int j = 1; j < todolist.Count; j++)
                {

                    Console.WriteLine($"{ todolist[j]}");

                }

                Console.WriteLine($"");



            }
            


            Console.ReadKey();

        }
     
       
    }
}
