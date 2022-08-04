using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    internal class _05_07
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Game();
                Console.WriteLine("---------------");
                Console.WriteLine("0 종료, 1:한번 더하기");
                Console.Write("입력: ");

                int answer = int.Parse(Console.ReadLine());
                if(answer == 0)

            }
            Console.WriteLine("게임 종료...");
        } 
    
        public static void Game()
        {
            string[] words = { "가위", "바위", "보" };

            string comWord = null;
            string youword = null;

            while (true)
            {
                Console.Write("가위, 바위, 보 입력: ");

                try
                {
                    Console.Write("가위, 바위, 보");

                    if (!words.Contains(youword))
                        throw new Exception("가위, 바위, 보 중에서 하나만 내세요.");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
                Random random = new Random();
                comWord = words[random.Next(3)];

            Console.WriteLine("컴퓨터 결과: " +comWord);

            if (comWord == "가위" &&.youWord == "가위")
                Console.WriteLine("무승부");
            else if 
        
        }
    }
}
