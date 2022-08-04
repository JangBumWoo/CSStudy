using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car // Car를 상속받음, 우클릭 후 추상클래스 구현
    {
        private int cc;


        // 우클릭 후 생성자 (부모 초기화)
        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc; // cc 초기화
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan SpeedDown...");
            //  base.speed -= speed; 하면 오류 뜸 Car에서 private이기 때문에
        } 


        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedUn...");
        }

        public override void Show()
        {
            Console.WriteLine("=============");
            Console.WriteLine("차량명: " + name);
            Console.WriteLine("차량색: " + color);
            Console.WriteLine("속도: " + speed);
            Console.WriteLine("배기량: " +cc);
            Console.WriteLine("=============");
        }
        // 부모에게도 Show가 있음 
        // 원래 public new void라서 부모의 Show 하이딩함

    }
}
