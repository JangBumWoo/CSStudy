using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 객체의 직렬화
 *  객체를 스트림을 통해 외부 파일로 생성하기 위한 작어빙다
 *  스트림으로 전송된 객체를 Serializable 어트리뷰트를 선언한다
 *  외부의 객체파일을 다시 객체로 복원하는 것을 역직렬화라고 한다.
 * 
 * 
 * 
 */
namespace Lone._05
{
    [Serializable]
    class Orange
    {
        private string country;
        private int price;

        public Orange(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("원산지: " + country);
            Console.WriteLine("가격: " + price);
        }
    }

    internal class _05_06
    {
        static void Main(string[] args)
        {
            string path = "C:||Users||1302||Desktop||Orange.dat";

            // 직렬화
            using (FileStream fs = new FileStream(path,BinaryReader))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                Orange orange = new Orange("캘리포니아", 5000);
                serializer.Serialize(fs, orange);  
            }
            // 역직렬화
            {
                using (FileStream fs = new FileStream(path, ))
                {

                }
            }
        }
    }
}
