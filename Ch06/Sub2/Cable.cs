using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // Socket이 전구와 Cable연결해준다
    internal class Cable : Socket
    {
        private Bulb bulb; // 전구를 속성으로, 벌브 초기화 

        public Cable(Bulb bulb) // 생성자
        {
            this.bulb = bulb;
        }

        public void SwitchOff()
        {
            bulb.LightOff();
        }

        public void SwitchOn()
        {
            bulb.LightOn();
        }
    }
}
