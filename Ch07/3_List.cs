using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 내용: 컬렉션 리스트 실습하기 교재 p211
 * 
 * 리스트 (List)
 *  - 배열과 유사한 선형 자료구조로 배열과 다르게 동적으로 데이터를 처리
 *  동적: 삽입, 삭제 가능 
 *  - ArrayList 일반화시켜 더나은 성능을 사진 List를 사용 
 * 
 */
namespace Ch07
{
    internal class _3_List
    {
        static void Main3(string[] args)
        {
            ////////////////////////////////
            // ArrayList
            ////////////////////////////////
         
            // ArrayList 생성
            ArrayList arrList1 = new ArrayList();
            // 제네릭 x 일반 클래스

            // 데이터 추가
            arrList1.Add(1);
            arrList1.Add(2);
            arrList1.Add(3);
            arrList1.Add(4);
            arrList1.Add(5);

            // 데이터 삽입
            arrList1.Insert(1, 6);
            // 0,1,2,3,4 있으면 두번째 자리에 6 삽입
            // 데이터가1,6,2,3,4,5가 됨

            // 데이터 삭제
            arrList1.Remove(6);  // 데이터 6을 삭제. 6번째 칸 삭제 X
            arrList1.RemoveAt(0); // 첫번재칸 1 삭제
            
            // 데이터 출력: 배열 반복문으로
            foreach(int n in arrList1)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();

            // 다양한 타입의 데이터를 갖는 ArrayList
            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(1.23);
            arrList2.Add(true);
            arrList2.Add('A');
            arrList2.Add("Apple");

            for (int i=0; i<arrList2.Count; i++)
            {
                Console.Write(arrList2[i] + " ");
                // [] = 인덱스 참조 i로 하겠다
            }
            Console.WriteLine();
            ////////////////////////////////
            // List
            ////////////////////////////////

            // List 생성
            List<int> list1 = new List<int>();
            // 제네릭이다 
            
            // 데이터 추가
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            // 데이터 삽입
            list1.Insert(1, 6);

            // 데이터 삭제
            list1.Remove(4); // 데이터 4를 삭제
            list1.RemoveAt(1);

            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // 문자열 리스트
            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach (string city in list2)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();

            // 객체 리스트
            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));

            Apple apple = list3[0];
            apple.Show(); // 첫번째인 한국인 나타남 

            list3[1].Show(); // 미국사과
            list3[2].Show(); // 일본사과
        }

    }
}
