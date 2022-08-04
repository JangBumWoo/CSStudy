using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/20
 * 내용: 제네릭 실습하기 교재 p395
 * 
 * 제네릭(Geeric)
 *   - 클래스 내부의 변수의 타입을 동적으로 일반화시키는 문법 요소
 *   - 제네릭 사용으로 클래스를 범용성 있게 사용한다
 * 
 * 
 */

namespace Ch06
{
    class FruitBox<T> // 제네릭 선언 
    {
        private T fruit; // 참조선언 using
        // T는 치환 변수

        // 초기화를 위해 생성자 
        public FruitBox(T fruit)
        {
            this.fruit = fruit; 
        }

        public T Fruit { get => fruit;} // 캡슐화

     //   public T GetFruit()
     //   {
     //       return fruit;
     //   } 위의 get 캡슐화와 같은 의미!
    }



    internal class _4_제네릭
    {

        static void Main23424(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 2000);

            FruitBox<Apple> box1 = new FruitBox<Apple>(apple); //Fruitbox에 apple을 담음

            FruitBox<Banana> box2 = new FruitBox<Banana>(banana);

            box1.Fruit.Show();
            box2.Fruit.Show();
            // box2.GetFruit().Show(); 같다
        }
    }
}

