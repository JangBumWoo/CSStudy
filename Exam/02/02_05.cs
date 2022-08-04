using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{


    /*
     * 
     * 이진탐색
     *  - 이진탐색은 전체 원소가 정렬된 상태에서 중앙값을 기준으로 절반은 버리고
     *    나머지 절반을 대상으로 검색을 수행하는 알고리즘
     * 
     * 검색방법
     *  1단계: 배열의 중앙값을 찾는다
     *  2단계: 검색하고자 하는 값보다 중앙값이 크면 중앙값의 오른쪽을 버린다.
     *  3단계: 다시 왼쪽 절반에 대해서 중앙값을 찾는다.
     *  4단계: 위와 같이 방법 수행을 통해 검색하고자 하는 값을 발견할 수 있다.
     * 
     * 
     */
    internal class _02_05
    {
        static void Main4545(string[] args)
        {
            int[] arr = { 5, 10, 18, 22, 35, 55, 75, 103, 152 };

            Console.Write("검색할 숫자 입력: ");
            int value = int.Parse(Console.ReadLine());

            int start = 0;
            int end = arr.Length - 1;
            int loc = 0;
            bool state = false;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] > value)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < value)
                {
                    start = mid + 1;
                }
                else
                {
                    loc = mid;
                    state = true;
                    break;
                }

                if (state)
                    Console.WriteLine("찾은 위치: {0}번째 있습니다.", loc + 1);
                else
                    Console.WriteLine("찾는 숫자가 없습니다.");









            }
        }
    }
}
