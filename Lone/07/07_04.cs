using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._07
{
    internal class _07_04
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1) int로 변환할 문자열 입력: ");
            input = Console.ReadLine();

            bool result = Int32.TryParse(input, out value);

            if(!result)
                Console.WriteLine("'{0}'는 int로 변환할 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환했습니다.\n", value);

            Console.Write("2) double로 변환할 문자열 입력: ");
            input=Console.ReadLine();

            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환했습니다.\n", m);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
