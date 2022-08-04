using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 내용: 구조체 실습하기 교재 p404
 * 
 * 구조체(Structure)
 *  - 간단하게 객체를 만들 때 사용하는 구조 형식 
 *  - 클래스와 동일하지만 상속, 다형성 등 지원 안 함
 * 
 */

namespace Ch06
{
    struct Point
    {
       public int x;
       public int y;

        public Point(int x, int y) // 생성자 정의
        {
            this.x = x;
            this.y = y;
        }

        public int Add() // 메서드 정의
        {
            return x + y;
        }



    }


    internal class _3_구조체
    {
        static void Main3(string[] args)
        {
            // Point p1 = new Point();
            // new를 하면 객체 형태로 heap에
            Point p1;
            p1.x = 1;
            p1.y = 2;

            Console.WriteLine("p1 Add: "+p1.Add());

            Point p2 = new Point(2, 3); // 생성자가 있기 때문에
            

            Console.WriteLine("p2 Add: "+p2.Add());

        
        
        }
    }
}
