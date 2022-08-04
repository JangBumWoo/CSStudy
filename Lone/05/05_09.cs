using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    class Mystack
    {
        const int maxSize = 10;
        private int[] arr = new int [maxSize];
        private int[] top;

        public Mystack()
        {
            top = 0;
        }
        public void Push(int val)
        {
            if (top < maxSize)
            {
                arr[top] = val;
               
                else
                {
                    Console.WriteLine("Stuck Full!");
                    return;
                }
        }
    
    }


    internal class _05_09
    {
            static void Main(string[] args)
            {
                Mystack mStack = new Mystack();
                Random rand = new Random();

                for (int i =0; i<10; i++)
                {
                    int val = rand.Next(1, 100);
                    mStack.Push(val);
                    Console.WriteLine($"Push({val}");
                }

                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Pop() = {mStack.Pop()}");
                }
            }
    }
}
