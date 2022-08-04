using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/18 
 * 이름: 김철학
 * 내용: 클래스 변수, 클래스 메서드 실습하기 교재 p225
 * 
 * 클래스 변수, 클래스 메서드
 * - Static을 선언한 메서드로 Data 영역 멤뢰 공간에 하나의 클래스로 관리
 * - 클래스 이름으로 직접 참조하거나 호출한다.
 * 
 */

namespace Ch05.Sub2
{
    internal class Car
    {
        // 속성(필드)
        private  string name;
        private  string color;
        private int speed;

        // 우클릭 그리고 여전히 속성 사용하는 캡슐화
        // Getter, Setter: C#에서 '프로퍼티'라고 함 
        public string Name 
        {
            get => name; // get: 필드값을 외부에 제공
            set => name = value; 
        }
        public string Color 
        { 
            get => color;
            set => color = value; 
        }
        public int Speed 
        {
            get => speed; 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;

                }
                else
                {
                    speed = value;
                }
            }
        }

        // 생성자
        public Car()
        {
            // 기본 생성자
        }

        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }

        // public Car부터 여기까지 오버로딩 메서드

        public void SpeedUp(int speed)
        {
            this.Speed += speed;
        }

        // 구분하기 위해 this를 넣어줌 this는 위의 class Car를 의미한다

        public void SpeedDown(int speed)
        {
            this.Speed -= speed;
            // 앞에 speed는 속성의 speed
        }
        
        
        public void Show() // Show는 보통 출력할 때 사용한다
        {
            Console.WriteLine("=============");
            Console.WriteLine("차량명: " +Name);
            Console.WriteLine("차량색: "+Color);
            Console.WriteLine("현재속도: "+Speed);
            Console.WriteLine("=============");
            
           
        }

    }
}
