using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _4_기본_입출력
    {

        static void Main(string[] args)
        {
            // 이름 입력
            Console.Write("이름 입력: "); // 출력 
            string name = Console.ReadLine(); // 입력 (서로 반대)

            // 나이 입력
            Console.WriteLine("나이 입력: "); // write는 그대로 있고 writeLine은 커서 필요
            string age = Console.ReadLine(); // 입력 (서로 반대)

            // 주소 입력 
            Console.Write("주소 입력: "); 
            string addr = Console.ReadLine();

            Console.WriteLine("이름: " +name);
            Console.WriteLine("이름: " +age);
            Console.WriteLine("이름: " +addr);
        }
    }
}
