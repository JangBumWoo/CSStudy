using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 상속에서 자식 클래스가 참조할 수 있도록 protected로 수정
        // 속성(필드)
        protected string name;
        protected  string color;
        protected int speed;
       // protected로 해야 자식이 부모를 참조할 수 있음 private나 public XX


        // 생성자
    
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            
        }

        // public Car부터 여기까지 오버로딩 메서드

        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }

        // 구분하기 위해 this를 넣어줌 this는 위의 class Car를 의미한다

        public void SpeedDown(int speed)
        {
            this.speed -= speed;
            // 앞에 speed는 속성의 speed
        }
        
        
        public void Show() // Show는 보통 출력할 때 사용한다
        {
            Console.WriteLine("=============");
         
            Console.WriteLine("차량명: " +name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("현재속도: "+speed);
            Console.WriteLine("=============");
            
           
        }

    }
}
