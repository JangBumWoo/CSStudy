using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 내용: 오버라이드 메서드실습하기
 * 오버로딩과 오버라이딩 차이점 알기!
 * 
 * 오버라이드(Override)
 *  - 부모 클래스의 메서드를 자식 클래스에서 다시 재정의(덮어쓰기) 하는 메서드
 *  - 오버라이드를 통해 다형성을 실현한다.
 */

namespace Ch05
{
    class AAA 
    { 
        public virtual void Method1()
        {
            Console.WriteLine("AAA:Method1...");
        }

        public virtual void Method2()
        {
            Console.WriteLine("AAA:Method2...");
        }

        public virtual void Method3()
        {
            Console.WriteLine("AAA:Method3...");
        }
        // 사라질 애들은 virtual을 선언해서 가독성 높임

    }
    
    class BBB : AAA // AAA를 상속받음
    {
        // Method hidding은 new를 통해서! - BBB의 Method1은 AAA의 Method1 을 숨긴다.
        public new void Method1()
        {
            Console.WriteLine("BBB:Method1...");
        }

        // Method Override : BBB의 Method2는 AAA의 Method2를 덮어씌운다.
        public override void Method2()
        {
            Console.WriteLine("BBB:Method2...");
        }

        // Method Overload: BBB의 Method3과 AAA의 Method3은 매개변수로 구분됨
        public void Method3()
        {
            Console.WriteLine("BBB:Method3...");
        }

    }

    class CCC : BBB // BBB를 상속받음 
    {
        // Method Hiding: CCC의 Method1은 BBB의 Method1을 숨김
        public new void Method1()
        {
            Console.WriteLine("CCC:Method1...");
        }

        // Method Override: CCC의 Method2는 BBB의 Method2를 덮어씌움
        public override void Method2()
        {
            Console.WriteLine("CCC:Method2...");
        }

        // Method Override: CCC의 Method3는 AAA의 Method3을 덮어씌움 
        public void Method3(int a)
        {
            Console.WriteLine("CCC:Method3...");
        }

    }

    internal class _5_오버라이드_메서드
    {
        static void Main34(string[] args)
        {
            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();
     
            b.Method1();
            b.Method2();
            b.Method3(); 
            Console.WriteLine();
            /// AAA는 오버라이드(하이딩)돼서 BBB만 나타남
        
            c.Method1();
            c.Method2();  
            c.Method3(1); // 인자값이 있기 때문에 BBB
            Console.WriteLine();
            // BBB, AAA는 오버라이드





        }
    }
}
