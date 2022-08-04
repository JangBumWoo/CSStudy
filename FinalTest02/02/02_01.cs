using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest02._02
{
    internal class _02_01
    {
        static void Main(string[] args)
        {
            Console.Write("연도 입력: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("{0}은 윤년입니다.", year);
            }

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년입니다.", year);
            }
        }
    }
}
