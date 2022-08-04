using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class TV : Internet, Computer // : Internet, Computer
                                           // 부모가 두개 될 수 X 하나는 인터페이스로
    {
        public void PowerOn() // TV 자체 기능
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
    }
}
