using Ch07.Sub1;
using System;
using System.Collections; // 콜렉션 using함 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 내용: 컬렉션 딕셔너리 실습하기
 * 
 * 딕셔너리(Dictionary)
 *  - 키값(Key-Value) 쌍으로 이루어진 자료 구조
 *  - Dictionary는 Hashtable을 일반화 시켜 더 나은 성능을 제공한다
 *  - list와 더불어 가장 많이 사용하는 자료구조
 */
namespace Ch07
{
    internal class _4_Dictionary
    {
        static void Main4(string[] args)
        {
            //////////////////////////
            // HashTable
            //////////////////////////

            // 테이블 생성
            Hashtable table = new Hashtable();

            // 데이터 추가
            table['A'] = "Apple";
            table.Add('B', "Banana");
            table.Add('C', "Cherry");

            // 키(k)      Value
            // A        Apple
            // B        Banana
            // C        Cherry
            // 순서가 없음

            //데이너 삭제
            table.Remove('C');
            // Cherry삭제

            //데이터출력
            foreach (char k in table.Keys)
            {
                Console.WriteLine("table: " + table[k]);
            }

            //////////////////////////
            // Dictionary
            //////////////////////////
            
            // 딕셔너리 생성
            Dictionary<char, object> dic = new Dictionary<char, object>();

            // 데이터 추가
            dic['A'] = "Apple";
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");

            // 데이터삭제
            dic.Remove('B');

            foreach (string fruit in dic.Values)
            {
                Console.WriteLine("dic: " + fruit);

            }

            // 해쉬테이블: key로 반복문
            // 딕셔너리는 fruit로 반복문

            // 딕셔너리 연습I
            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            ///         people
            ///     k            v
            ///     101         김유신
      
            foreach (int k in people.Keys)
            {
                Console.WriteLine($"K: {k}, V: {people[k]}");
            }

            /// d1
            ///      k            v
            ///      101        Apple (한국, 3000)
            ///      102        Apple (미국, 2000)
            ///      102        Apple
            /// d2
            ///      k            v
            ///      201        Apple (중국, 3000)
             
             
            


            // 딕셔너리 연습II
            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();



            d1.Add(101, new Apple("한국", 3000)); // 객체 저장
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));


            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            // d1, d2, d3를 리스트로 만들기

            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();

            // 리스트 <> 안에 변수인  Dictionary<int, Apple>가 되어야 함
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);

            // 한국 사과 출력
            Dictionary<int, Apple> dicApple = apples[0];
            // dicApple = d1
            Apple apple =  dicApple[101];
            apple.Show();

            // 미국사과 출력
            apples[0][102].Show();
            
            // 대만 사과
            apples[1][202].Show();

            //인도 사과
            apples[2][303].Show();






        }

    }
}
