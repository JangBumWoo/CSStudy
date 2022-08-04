using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 내용: 백준 1단계 5번 문제 A+B
 * 
 */
namespace Backjun._1단계
{
    internal class _01_05
    {
        static void Main5(string[] args)
        {
          //  Console.WriteLine("두 수를 입력: ");
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
           
            Console.WriteLine(a+b);
           // foreach (string s in inputs)
           // {
           //     Console.WriteLine(s);
           // }
           

        }
    }
}
