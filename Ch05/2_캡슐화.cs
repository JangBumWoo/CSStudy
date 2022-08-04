using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/18
 * 이름: 장수미
 * 내용: 클래스 실습하기 교재 p203
 * 
 * 캡슐화(Encapsualation)
 *  - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보(속성)를 은닉하는 특성
 *  - 캡슐화를 위해 접근 제한자 public, private, protected를 사용한다
 *  - 은닉된 정보의 안전한 제공을 위해 Getter, Setter를 사용(프로퍼티)
 * 
 */

namespace Ch05
{
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
           // 객체 생성과 초기화
            
            Account kb = new Account("국민은행", "101-12-1010", "김유신", 10000);


            // 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);

            // 캡슐화로 취약코드 예방    
            //  kb.balance--;

            kb.Show();

            // Car 객체 생성과 초기화
            Car sonata = new Car("소나타", "흰색", 0);
            sonata.SpeedUp(100);
            sonata.SpeedDown(20);
            sonata.Show();

            // Getter, Setter 활용한 객체
            Car bmw = new Car();

            bmw.Name = "BNW 520";
            bmw.Color = "남색";
            bmw.Speed = -10;

            sonata.Name = "소나타 EF"; // 대문자 N
            sonata.Color = "은색";
            sonata.Speed = 100;

            Console.WriteLine("sonata name: "+sonata.Name);
            Console.WriteLine("sonata color: "+sonata.Color);
            Console.WriteLine("sonata speed: "+sonata.Speed);
        }
    }
}
