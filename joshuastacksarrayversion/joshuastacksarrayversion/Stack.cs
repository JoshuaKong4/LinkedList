using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joshuastacksarrayversion
{
    class Stack<T>
    {
        T[] stackarray= new T [4];

        int count = 0;
        public Stack()
        {
         

        }
        public void Push (T addvalue)
        {
            if (count < 0)
            {
                Console.WriteLine($"The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible. The second time you fail to complete a lap before the sound, your test is over. The test will begin on the word start. On your mark, get ready, start.");

            }
            else
            {
                if (count >= stackarray.Length)
                {
                    T[] temp = new T[count * 2];
                    for (int i = 0; i < count; i++)
                    {
                        temp[i] = stackarray[i];
                    }
                    stackarray = temp;
                }
                stackarray[count] = addvalue;
                count++;
            }
        }
        public void Pop ()
        {
            if (count < 0)
            {
                Console.WriteLine($"The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible. The second time you fail to complete a lap before the sound, your test is over. The test will begin on the word start. On your mark, get ready, start.");

            }
            else
            {
                count--;
                if (count * 2 >= stackarray.Length)
                {
                    T[] temp = new T[count];
                    for (int i = 0; i < count; i++)
                    {
                        temp[i] = stackarray[i];
                    }
                    stackarray = temp;
                }
            }

        }
        public void Peek ()
        {
            if (count < 0)
            {
                Console.WriteLine($"The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible. The second time you fail to complete a lap before the sound, your test is over. The test will begin on the word start. On your mark, get ready, start.");

            }
            else
            {
                Console.WriteLine($"{stackarray[count-1]}");
            }
        }

    }
}
