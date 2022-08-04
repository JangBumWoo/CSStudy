using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 그리드뷰 데이터 공급을 위한 리스트
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        
        
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 입력 데이터 저장
            string uid = txtId.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, age);
            MessageBox.Show("데이터가 추가되었습니다.", "확인");
            ClearText();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        public void ClearText()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
                
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow dataRow = dataGrid.Rows[row];

           txtId.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();  
            txtHp.Text = dataRow.Cells[2].Value.ToString();  
            nAge.Text = dataRow.Cells[3].Value.ToString();  


            Console.WriteLine(dataRow.Cells[0].Value.ToString());
            Console.WriteLine(dataRow.Cells[1].Value.ToString());
            Console.WriteLine(dataRow.Cells[2].Value.ToString());
            Console.WriteLine(dataRow.Cells[3].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 입력데이터 저장
            string uid = txtId.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            MessageBox.Show("데이터가 수정 되었습니다.", "확인");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}