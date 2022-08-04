using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Car
    {
        // 속성(필드)
        private  string name;
        private  string color;
        private int speed;
        private static int count; // static


        // 생성자
    
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            count++; // this가 붙지 않음
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
            Console.WriteLine("차량번호: " +count);
            Console.WriteLine("차량명: " +name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("현재속도: "+speed);
            Console.WriteLine("=============");
            
           
        }

    }
}
