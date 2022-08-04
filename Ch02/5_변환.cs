using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _5_변환
    {
        static void Main5(string[] args)
        {
            // 작은 변수에서 큰 변수
            byte num1 = 255;    // 1byte
            short num2 = num1;  // 2byte
            int num3 = num2;    // 3byte

            Console.WriteLine("num1 : {0}" , num1);
            Console.WriteLine("num2 : {0}" , num2);
            Console.WriteLine("num3 : {0}" , num3);

            // 큰변수에서 작은 변수로 데이터 이동 (그냥 하면 error)

            int var1 = 256;
            short var2 = (short) var1; // Casting
            byte var3 = (byte) var2; // 255까지가 범위


            Console.WriteLine("var1 : {0}", var1);
            Console.WriteLine("var2 : {0}", var2);
            Console.WriteLine("var3 : {0}", var3);

            // 정수에서 실수
            int a = 1;
            int b = 2;
            int c = 3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : {0}", d1);
            Console.WriteLine("d2 : {0}", d2);
            Console.WriteLine("d3 : {0}", d3);

            // 실수에서 정수
            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            int r1 = (int) n1;
            int r2 = (int) n2;
            int r3 = (int) n3;

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);

            

        
        }
    }
}
