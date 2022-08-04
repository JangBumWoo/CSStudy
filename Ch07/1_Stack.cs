using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/25
 * 이름: 장수미
 * 내용: 컬렉션 스택 실습하기
 * 
 * 스택(Stack)
 *  - 가장 기본적인 자료구조
 *  - 한쪽 끝에서만 자료를 넣거나 빼는 선형구조(LIFO:후입선출) 나중에 들어간 것이 먼저 빠짐
 *  - 다양한 알고리즘 및 함수 호출에 사용 
 */


namespace Ch07
{
    internal class _1_Stack
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            // 스택은 제네릭

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
           // 5,4,3,2,1... 1까지
            {
                Console.WriteLine(stack.Pop());
            }
        }

    }
}
