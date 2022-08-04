using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 내용: 인덱서 실습하기
 * 
 * 인덱서 (Indexer)
 *  - 객체를 배열처럼 인덱스를 활용하여 객체의 속성ㅇ을 참조할 수 ㅣㅇㅆ게 해주는 속성
 *  - 인덱서를 메서드로 대체 가능 
 * 
 * 
 * 
 * 
 */

namespace Ch06
{
    class MyArray
    {
        private int[] array;
        public MyArray()
        {
            array = new int[3]; // 생성자에서 배열의 크기가 정해진다
        }

        // 인덱서
        public int this[int i] // 인덱스 변수 i 선언
            // this = Class 'MyArray'
        {
            get { return array[i]; }

            set
            {
                if (i < array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더이상 데이터를 저장할 수 없습니다.");
                }
            }
        }
     
       
    }

    internal class _5_인덱서
    {
        static void Maindf(string[] args)
        {
            MyArray mArr = new MyArray();
            mArr[0] = 100;
            mArr[1] = 200;
            mArr[2] = 300;
            // [0] 인덱서 호출
            // 세칸이라 mArr[3] = 400;은 안된다

            for (int i=0; i<3; i++)
            {
                Console.Write(mArr[i] + " ");
                // mArr[i]는 getter
                // 인덱서의  get { return array[i]; }가 실행된다
            }



        }
    }
}
