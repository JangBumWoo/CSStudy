namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메시지박스");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "버튼2 클릭"); // "메인", "제목"
        }

        private void bt3_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("두 개의 버튼을 갖는 메시지 박스",
                            "버튼3 클릭",    
                            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 클릭!");
            }
            else
            {
                MessageBox.Show("No 클릭!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과: " + uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "결과: " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과: " + hp;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnChkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkfruit1, chkfruit2, chkfruit3, chkfruit4, chkfruit5 }; // 체크박스 배열 
            List<string> fruits = new List<string>();

            foreach (CheckBox chk in chkFruits) // 체크박스 반복문
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "결과: " + String.Join(", ",fruits);
        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColors = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();

            foreach (CheckBox chk in chkColors)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            lbColorResult.Text = "결과: " + String.Join(", ", colors);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}