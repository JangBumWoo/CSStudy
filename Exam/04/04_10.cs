using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class Human
    {
        private string name;

        public Human (string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine(name+"입니다.");
        }
    }

    class Worker
    {
       public Worker (string name) : base(name)
        {

        }


        public virtual void Show()
        {
            Console.WriteLine("작업을 합니다.");
        }
    }

    class Developer
    {
        public Worker(string name) : base(name)
        {

        }
        public virtual void Show()
        {
            Console.WriteLine("개발을 합니다.");
        }
    }

    class Professor
    {
        public Worker(string name) : base(name)
        {

        }
        public virtual void Show()
        {
            Console.WriteLine("연구를 합니다.");
        }
    }

    internal class _04_10
    {
        static void Main3(string[] args)
        {
            Worker worker = new Worker("김유신");
           Developer developer = new Developer("김춘추");
            Professor professor = new Professor("장보고");

            people = { worker, developer, professor};

            foreach()
            {

                Console.WriteLine();
            }

        }
    }
}
