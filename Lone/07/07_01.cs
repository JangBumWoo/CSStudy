using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._07
{
    internal class _07_01
    {

        static void Main(string[] args)
        {
            Console.Write("이름 입력: ");
            string name =Console.ReadLine();

            Console.Write("나이 입력: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("키 입력: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.WriteLine("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 입니다.");
        }
    }
}
