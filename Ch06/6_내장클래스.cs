using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/21 
 * 내용: 자주 사용하는 내장크래스 실습하기 
 * 
 * 
 * 
 * 
 */

namespace Ch06
{
    internal class _6_내장클래스
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////
            // Math 클래스
            //////////////////////////////////////
            //Math math = new Math();
            Console.WriteLine("PI: " + Math.PI);    // PI: static 변수
            Console.WriteLine("9 제곱근: " + Math.Sqrt(9));
            Console.WriteLine("16 제곱근: " + Math.Sqrt(16));
            Console.WriteLine("절대값: " + Math.Abs(-5));
            Console.WriteLine("올림값: " + Math.Ceiling(1.2));
            Console.WriteLine("올림값: " + Math.Ceiling(1.8));
            Console.WriteLine("내림값: " + Math.Floor(1.2));
            Console.WriteLine("내림값: " + Math.Floor(1.8));
            Console.WriteLine("반올림: " + Math.Round(1.2));
            Console.WriteLine("반올림: " + Math.Round(1.8));
            Console.WriteLine();

            //////////////////////////////////////
            // Random 클래스
            //////////////////////////////////////
            Random rand = new Random();

            double num1 = rand.NextDouble();
            Console.WriteLine("num1: " +num1); // 0~1 사이 임의의 실수

            double num2 = num1 * 10;
            Console.WriteLine("num2: " +num2); // 1~10 사이의 임의의 실수

            double num3 = Math.Ceiling(num2);
            Console.WriteLine("num3: "+ num3); // 1~ 10 사이 임의의 정수

            int rNum1 = rand.Next();
            Console.WriteLine("rNum1: " +rNum1); // 0에서부터 시작하는 임의의 정수

            int rNum2 = rand.Next(10);
            Console.WriteLine("rUnm2: " +rNum2); // 0~9 사이의 임의의 정수

            int rNum3 = rand.Next(1, 11);
            Console.WriteLine("rUnm3: " + rNum3); // 1 ~ 10 사이의 임의의 정수
            Console.WriteLine();

            //////////////////////////////////////
            // DateTime 클래스
            //////////////////////////////////////

            // 싱글톤 객체
            DateTime dt = DateTime.Now; // Now를 써야함

            Console.WriteLine("dt: " +dt);
            Console.WriteLine("년: " + dt.Year); 
            Console.WriteLine("월: " + dt.Month); 
            Console.WriteLine("일: " + dt.Day); 
            Console.WriteLine("시: " + dt.Hour); 
            Console.WriteLine("분: " + dt.Minute); 
            Console.WriteLine("초: " + dt.Second);

            // 문자열 format을 이용해 날짜 출력
            string result1 =  dt.ToString("yyyy-MM-dd");
            Console.WriteLine("resulrt1: " +result1);

            string result2 = dt.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("resulrt1: " + result2);
        }
    }
}
