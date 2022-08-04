using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    internal class _05_03
    {
        static void Main(string[] args)
        {
            printList(createList());

        }

        public static void printList(int scoreList)
        {
            int total = 0;
            int count = scoreList.Count;

            for (int i = 0; i < count; i++)
            {
                int score =

                      total += score;

                Console.Write(score);

                if (i == count - 1)
                    Console.Write(" = ");

                else
                    Console.Write(" + ");

            }

            Console.WriteLine();

        }

        public static int createList()
        {
            List<int> scoreList = new List<int>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                // 60 ~ 100 사이 임의의 수
                int num = ReaderWriterLock.Next(41) + 60;

            }
            return scoreList;
        }
    }
}
