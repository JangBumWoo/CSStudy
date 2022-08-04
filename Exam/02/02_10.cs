using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    /* 
     * 내용: 피보나치 수열 연습문제
     */

    internal class _02_10
    {
        static void Main34(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(fibo(i) + " ");
            }
        }

        public static int fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return fibo(n-1) + fibo(n-2);                                                                                                                                                                                                                                                                       

        }
    }
}
