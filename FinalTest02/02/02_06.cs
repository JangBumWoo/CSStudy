using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest02._02
{
    internal class _02_06
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j =2; j <=i; j++)
                {

                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact);
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:n0}\n", n, sum);
        }
    }
}
