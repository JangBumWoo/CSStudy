using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 내용: Linq 실습하기 교재 p525 
 *
 * Linq
 *  - Linq(Language Intergrated Query)는 컬렉션을 대상으로 데이터를 처리하기 위한 C# 질의언어
 *  - Linq를 사용해서 DB와 함께 데이터를 쉽게 관리 
 *  
 *
 */

namespace Ch09
{
    class Member
    {
        private string name;
        private string uid;
        private int age;

        public Member(string name, string uid, int age)
        {
            this.name = name;
            this.uid = uid;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Uid { get => uid; set => uid = value; }
        public int Age { get => age; set => age = value; } //캡슐화, 여전히 필드 사용
    } // 멤버 정의

    internal class _3_Linq
    {
        static void Main(string[] args)
        {
            // 컬렉션 생성
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 결과 리스트 생성
            List<int> rsList1 = new List<int>();
            List<int> rsList2 = new List<int>();

            // for문 이용한 짝수 추출
            foreach (int n in myList)
            {
                if (n % 2 == 0)
                {
                    rsList1.Add(n);
                }
            }

            // 람다식을 이용한 짝수 호출
            myList.ForEach((n) => {
                if (n % 2 == 0)
                {
                    rsList2.Add(n);
                }
            });

            // Linq 이용한 짝수 호출
            var rsList3 = from n in myList
                          where n % 2 == 0 // 조건
                          select n;

            Console.WriteLine("rsList1: " +String.Join(",", rsList1));
            Console.WriteLine("rsList1: " +String.Join(",", rsList2));
            Console.WriteLine("rsList2: " +String.Join(",", rsList3));

            // 데이터가 5이상 큰 순서대로 추출 
            var rsList4 = from n in myList
                          where n >= 5
                          orderby n descending
                          select n;
            Console.WriteLine("rsList4: " + String.Join(",", rsList4));

            // Linq 객체 리스트 활용 
            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", 25));
            members.Add(new Member("a102", "김춘추", 23));
            members.Add(new Member("a103", "장보고", 45));
            members.Add(new Member("a104", "강감찬", 55));
            members.Add(new Member("a105", "이순신", 55));

            // 30세이상, 이름 사전순 추출 
            var rsList5 = from m in members
                          where m.Age >= 30
                          orderby m.Name ascending // 오름차순
                          select m;

            foreach (Member m in rsList5)
            {
                Console.WriteLine("{0},{1},{2}", m.Uid, m.Name, m.Age);
            } 
        
        }
    }
}
