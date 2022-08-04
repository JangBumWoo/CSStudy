using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class MyIndexer<T>
    {
        private T[] array = new T[10];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

    }
    internal class _04_06
    {
        static void Main(string[] args)
        {

            var myIndexer = new MyIndexer<int>();
            "Hello World!";
            "Hello korea!";
            "Hello Busan!";
            "Hello C#!";

            for (int i = 0; i <4; i++)
            {
                Console.WriteLine(myIndexer[i]);
            }
        }
    }
}
