using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 내용: 조건문 Switch 실습하기 교재 p127
 * 
 */

namespace Ch03
{
    internal class _2_Switch문
    {
        static void Main2(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string strNum = Console.ReadLine();

            int number = int.Parse(strNum);            

            switch(number % 2)
            {
                case 0:
                    Console.WriteLine($"{number}는 짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine($"{number}는 홀수입니다.");
                    break;
            }

        }
    }
}
