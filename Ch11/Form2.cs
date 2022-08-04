using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form2 : Form
    {
        class User
        {
            private string uid;
            private string name;
            private string hp;
            private int age;

            public User(string uid, string name, string hp, int age)
            {
                this.uid = uid;
                this.name = name;
                this.hp = hp;
                this.age = age;
            }

            public string Uid { get => uid; set => uid = value; }
            public string Name { get => name; set => name = value; }
            public string Hp { get => hp; set => hp = value; }
            public int Age { get => age; set => age = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Form2가 실행될 때
        private void Form2_Load(object sender, EventArgs e)
        {
            // 콤보박스 데이터 공급
            List<string> posData = new List<string> { "사원", "대리", "과장", "차장", "부장" };
            cbPos.DataSource = posData;
            
            
            string[] cityData = { "서울", "대전", "대구", "부산", "광주"};
           cbCity.DataSource = cityData;

            //데이터그리드뷰 데이터 공급 
            List<User> users = new List<User>();
            users.Add(new User("a101", "김유신", "010-1234-1001",25));
            users.Add(new User("a102", "김춘추", "010-1234-1002", 23));
            users.Add(new User("a103", "장보고", "010-1234-1003", 35));
            users.Add(new User("a104", "강감찬", "010-1234-1004", 45));
            users.Add(new User("a105", "이순신", "010-1234-1005", 55));

            gridView.DataSource = users;
        
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            lbPos.Text = "결과: " + cbPos.Text;
        }

        private void btnCity_Click(object sender, EventArgs e)
        {

        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           // lbCity.Text = "결과: " + cbCity.SelectedText; 확인 버튼 없이 바로 결과
        }
    }
}
