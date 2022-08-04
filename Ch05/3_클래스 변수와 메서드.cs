using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 
 * 날짜: 2022/07/18
 * 이름: 장수미
 * 내용: 클래스 변수, 클래스 메서드 실습하기 교재 p225
 * 
 * 싱글톤
 *  - static을 활용한 가장 대표적인 객체 생성 방법
 *  - 싱글톤 패턴이 적용된 객체는 
 * 
 * 
 * 
 */


namespace Ch05
{
    class Increment
    {
        // Stack이 heap을 참고함
        public int num1;

        // Data 영역에 따로 관리되는 클래스 변수. 고정됨
        // heap은 data를 참고함
        // 0에서 1, 1에서 2(고정), 2에서 3
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1: {0}, num2: {1}", num1, num2);
        }

        // Data 영역에 따로 관리되는 클래스 메서드(정적 메서드)
        public static void Add()
        {
           // static 메서드(static 메서드)는 non-static 변수를 참조할 수 없다. 
           // num1++; 
            num2++;

            Console.WriteLine("num2: {0}", num2);
        }
    }

    internal class _3_클래스_변수와_메서드
    {
        static void Main343(string[] args)
        {
            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();

            // 클래스 변수 참조
            Increment.num2 = 10;

            // 클래스 메서드 실행
            Increment.Add();

            // 클래스 변수 활용한 객체
            Car car1 = new Car("소나타", "검정", 0); // Sub3 using하였음 
            car1.Show();

            Car car2= new Car("아반테", "검정", 0);
            car2.Show();

            Car car3 = new Car("싼타페","검정", 0);
            car3.Show();

            // 싱글톤 객체
            Calc cal = Calc.Instance; // Caclc가 싱글톤, 제공되는 객체를 이용함


            int r1 = cal.Plus(1, 2);
            int r2 = cal.Minus(1, 2);
            int r3 = cal.Multi(2, 3);
            int r4= cal.Div(4, 2);

            Console.WriteLine("r1: "+r1);
            Console.WriteLine("r2: "+r2);
            Console.WriteLine("r3: "+r3);
            Console.WriteLine("r4: "+r4);
        }
    }
}
