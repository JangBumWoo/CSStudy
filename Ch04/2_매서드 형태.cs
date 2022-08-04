using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜: 2022/07/14
 * 이름: 장수미
 * 내용: 메서드 타입 실습하기 교재 p265
 *  
 */

namespace Ch04
{
    internal class _2_매서드_형태
    {
        static void Main3(string[] args)
        {
            // 메서드 호출
            double y1 = Type1(0.12); // 인자값 0.12 전달
            double y2 = Type1(1.13); // 인자값 1.13 전달

            Console.WriteLine("y1: " +y1);
            Console.WriteLine("y2: " +y2);

            Type2(true); // 리턴값 없으면 앞에 대입연산자 X
            Type2(false);

            string result1 = Type3(); // 매개변수가 없음
            Console.WriteLine("Type3 result: " + result1);

            Type4();

        } // end of Main

        // Type1 : 매개변수 0, 리턴값 O
        public static double Type1(double x) // 더블이므로 실수
        {
            double y = x + Math.PI; // PI = 3.14
            return y; // double을 리턴하므로 static double
        }

        // Type2 : 매개변수 0, 리턴값 X
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("참입니다.");
            }
            else
            {
                Console.WriteLine("거짓입니다.");
            }
        }
   
        // Type3 : 매개변수 X, 리턴값 O 
        public static string Type3() // return이 문자열이므로 string       
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 > n2)
            {
                return "n1은 n2보다 크다.";
            }
            else           
            {
                return "n1은 n2보다 작다.";
            }
        }

        // Type4 : 매개변수 X, 리턴값 X
        public static void Type4()        
        {
            Console.WriteLine("Type4 result: " + Type1(1.12));
        }

    }
}
