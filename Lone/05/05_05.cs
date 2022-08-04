using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    class Apple
    {
        private string country;
        private int price;

        public Apple(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("사과 원산지: " +country);
            Console.WriteLine("사과 가격: " +price);
            Console.WriteLine();
        }
    }
    internal class _05_05
    {
        static void Main(string[] args)
        {
            List<Apple> list1 = new List<Apple>();
            list1.Add(new Apple("파주", 3000));
            list1.Add(new Apple("이천", 3000));
            list1.Add(new Apple("수원", 3000));

            List<Apple> list2 = new List<Apple>();
            list2.Add(new Apple("청주", 3000));
            list2.Add(new Apple("충주", 3000));
            list2.Add(new Apple("단양", 3000));

            List<Apple> list3 = new List<Apple>();
            list3.Add(new Apple("밀양", 3000));
            list3.Add(new Apple("함안", 3000));
            list3.Add(new Apple("합천", 3000));

            Dictionary<string, List<Apple>> dic = new Dictionary<string, List<Apple>>();
            dic.Add("gyeonggi", list1);
            dic.Add("chunbuk", list2);
            dic.Add("gyungnam", list3);

            // 수원 사과 출력 
            List<Apple> list = dic[];

            Apple apple = list[2];
            apple.Show();

            // 충주
            apples[2][102].Show();

            // 밀양
        }
    }
}
