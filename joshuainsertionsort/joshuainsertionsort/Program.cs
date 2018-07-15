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
            bool swap = false;

            List<int> todolist = new List<int>();
            List<int> havedonelist = new List<int>();


            for (int i = 0; i < 10; i++)
            {
             todolist.Add(rand.Next(1,1400));

                // Console.WriteLine($"{ todolist[i] }");
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    havedonelist.Add(i);

            //    Console.WriteLine($"{ todolist[i] }");
            //}
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                if (havedonelist.Count == 0)
                {


                    havedonelist.Insert(0, todolist[sortedindex]);
                    todolist.RemoveAt(sortedindex);

                }
                else if (havedonelist[count] < todolist[sortedindex])
                {

                    swap = false;
                    havedonelist.Insert(havedonelist.Count, todolist[sortedindex]);
                    todolist.RemoveAt(sortedindex);



                }
                else
                {
                    swap = true;
                    int index = 0;
                    havedonelist.Insert(0, todolist[0]);
                    todolist.RemoveAt(0);

                    for (int j = 0; j < havedonelist.Count - 1; j++)
                    {
                        if (havedonelist[j] < havedonelist[j + 1])
                        {
                            int temp = havedonelist[j + 1];
                            havedonelist[j + 1] = havedonelist[j];
                            havedonelist[j] = temp;



                        }


                    }


                }






                for (int j = 0; j < havedonelist.Count; j++)
                {
                    Console.WriteLine($"{ havedonelist[j]}sorted");

                }
       
                for (int j = 0; j < todolist.Count; j++)
                {

                    Console.WriteLine($"{ todolist[j]}");

                }
                Console.WriteLine($"{ swap}");

                Console.WriteLine($"");



            }
            


            Console.ReadKey();

        }
     
       
    }
}
