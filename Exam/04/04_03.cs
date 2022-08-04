using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
   
     class Employee
     {
            public string Name { get; set; } = "홍길동";
            public string Position { get; set; } = "사원";


            public void Show()
            {
                Console.WriteLine("===============");
                Console.WriteLine("이름: " + Name);
                Console.WriteLine("이름: " + Position);
                Console.WriteLine("---------------");
            }
    }

    internal class _04_03
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            Employee emp2 = new Employee();

            Employee emp3 = new Employee();
            { }
        }





    }
}
