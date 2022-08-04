using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    internal class _05_10
    {
        static void Main(string[] args)
        {
            // 배열
            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Console.WriteLine("배열");
            foreach (string name in arrNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            // 리스트
            List<string> listNames = new List<string>();
            listNames.Add("dog");
            listNames.Add("cow");
            listNames.Add("rabbit");
            listNames.Add("goat");
            listNames.Add("sheep");

            Console.WriteLine("리스트");
            foreach (string name in listNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
