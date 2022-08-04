using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class King
    {
        private string name;
        private int year;

        public King(int year) : this("정조")

        {
            this.year = year;
        }
        // 이름을 초기화
        public King(string name)
        { this.name = name; }

        public King(string name, int year)
        {
            this.year = year;
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("=============");
            Console.WriteLine("이름: " + name);
            Console.WriteLine("yaer: " + year);
            Console.WriteLine("--------------");


        }


    }





    internal class _03_02
    {
        static void Main34(string[] args)
        {
            King k1 = new King("태조", 1392);
            King k2 = new King("세종");
            King k3 = new King(1776);

            k1.Show();
            k2.Show();
            k3.Show();
        }
            

    }
}
