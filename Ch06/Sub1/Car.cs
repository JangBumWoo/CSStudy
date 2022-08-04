using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    // 추상클래스: 추상 메서드를 갖는 클래스
    internal abstract class Car // internal은 public과 같다
                                // abstract 추상 클래스로 선언
    {
        // 속성
        protected string name;
        protected string color;
        protected int speed;


        // 생성자
        protected Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }


        // 기능
        public abstract void SpeedUp(int speed); // 추상 메서드
        public abstract void SpeedDown(int speed);
        // 괄호 안에 int speed 넣어서 매개변수 ㅅ너언
        
        public virtual void Show() // virtual 선언
        {
            Console.WriteLine("=============");
            Console.WriteLine("차량명: "+name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("속도: "+speed);
        }

        // 속성 기능 적은 후 초기화를 위해 생성자를 형성함 우클릭!
        // 추상 메서드라도 완성된 기능이 있다
    }
}
