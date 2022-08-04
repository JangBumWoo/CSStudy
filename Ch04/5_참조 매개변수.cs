using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/14
 * 이름: 장수미
 * 내용: 메서드 참조 매개변수 실습하기 교재 p256
 */

namespace Ch04
{
    internal class _5_참조_매개변수 // return이 필요 X
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            MyDivier(num1, num2, ref num3, ref num4); // reference: 주소값

            Console.WriteLine("몫 : {0}, 나머지 : {1}" , num3, num4);

            // 

        } //end of Main

        public static void MyDivier(int n1, int n2, ref int result1, ref int result2)
        {
            result1 = n1 / n2; // result13에 저장한다
            result2 = n1 % n2;
        }

    }
}
