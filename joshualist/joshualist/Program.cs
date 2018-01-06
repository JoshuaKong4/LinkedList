using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshualist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            //ask the user to enter how many items they want to start with
            //then, create an array that is that large, and store all the users items into this array
            //then, show the items to the user, and ask them what they would like to do with this array
            //ask them if they want to:
            //1) view the list
            //2) add to the list
            //3) remove from the list
            //4) exit
            Console.WriteLine("How many items would you like your list to contain?");
            string[] list = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < list.Length ; i++)
            {
                Console.WriteLine("you may now enter an item into the list");
                list[i] = Console.ReadLine();
            }


           
            while (exit == false)
            {
                Console.WriteLine($"you have {list.Length}  item(s) . Would you like to: View(1), add(2), remove(3), or exit(4)?");
                int result2 = int.Parse(Console.ReadLine());
                if (result2 == 1)
                {
                    Console.WriteLine("Here is the list:");
                    for (int i = 0; i < list.Count(); i++)
                    {
                        Console.WriteLine($"    {list [i]}");
                    }
                }
                if (result2 == 2)
                {
               
                   
                    Console.WriteLine("enter the item name.");
                    string[] list2 = new string[list.Length +1];
                    list2[list.Length] = Console.ReadLine();
                    for (int i = 0; i < list.Length; i++)
                    {
                        list2[i] = list[i];
                    }
                    list = list2;
                    


                }
                if (result2 == 3)
                {
                  
                    Console.WriteLine("enter the item.");
                       
                    int deletenumber = int.Parse(Console.ReadLine())-1;
                    string[] list2 = new string[list.Length - 1];
                    for (int i = 0; i < list.Count(); i++)
                    {
                       if( list[i] == Console.ReadLine())
                        {


                        }

                    }
                        for (int i = 0; i < list2.Count(); i++)
                    {
                        if (i < deletenumber)
                        {
                            list2[i] = list[i];
                        }
                       else
                        {

                            list2[i] = list[i+1];
                        }
                    }

                        list = list2;
                }
                if (result2 == 4)
                {
                    Console.WriteLine("you have exited the list.");
                   exit = true;

                }
            }
            Console.WriteLine("your list is now complete.");
            Console.ReadKey();



        }
    }
}
