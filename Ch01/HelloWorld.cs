using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            // 기본출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            // 서식출력
            Console.Write("Hello\t");
            Console.Write("Korea\n");

            // 포맷출력
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
        }
    }
}
