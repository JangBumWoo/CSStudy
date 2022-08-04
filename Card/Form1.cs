namespace Card
{
    public partial class Form1 : Form
    {

        private TableLayoutPanel tlp;
        private RadioButton[] rb = new RadioButton[4];
        private Image cim;
        private Image[] mim = new Image[4];
        private PictureBox pb;
        private Label lb;
        private int num; // 카드 마크
        private bool isOpen; // 카드 앞뒤

        public static void Main()
        {
            Application.Run(new Form1()); // 윈도 프로그램 실행 
        }

        public Form1()
        {
            this.Text = "카드";
            this.Width = 650; this.Height = 450;

            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnCount = 4;
            tlp.RowCount = 2;


            for (int i = 0; i < rb.Length; i++)
            {
                mim[i] = Image.FromFile("C:\\Users\\502\\Desktop\\CD1\\mark" + i + ".bmp");
                rb[i] = new RadioButton();
                rb[i].Image = mim[i];
                rb[i].AutoSize = true;
                rb[i].Parent = tlp;
            }

            cim = Image.FromFile("C:\\Users\\502\\Desktop\\CD1\\card.bmp");
            pb = new PictureBox();
            pb.Image = cim;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Anchor = AnchorStyles.Right;
            pb.Parent = tlp;

            lb = new Label();
            lb.Font = new Font("SansSerif", 50, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Anchor = AnchorStyles.None;
            lb.Parent = tlp;

            tlp.SetColumnSpan(pb, 2);
            tlp.SetColumnSpan(lb, 2);

            tlp.Parent = this;

            isOpen = false; // 카드 뒷면
            Random rn = new Random(); // 카드 마크 랜덤 정함 
            num = rn.Next(4); 

            pb.Click += new EventHandler(pb_Click); 

        }

       public void pb_Click(Object sender, EventArgs e) // 카드를 클릭했을 때
        {
            if (isOpen == false) // 카드가 뒤면
            {
                isOpen = true; // 카드를 앞으로
                pb.Image = mim[num];

                if (rb[num].Checked == true) // 카드가 맞은 경우
                {
                    lb.ForeColor = Color.DeepPink; //ForeColor: 전경색 
                    lb.Text = "HIT!";
                }
                else // 카드가 맞지 않은 경우
                {
                    lb.ForeColor = Color.SlateBlue;
                    lb.Text = "MISS!";
                }
            }
            
            else // 카드가 앞이면
            {
                isOpen = false; // 카드를 뒤로
                lb.Text = "";
                pb.Image = cim;

                Random rn = new Random(); // 다음 마크를 랜덤으로
                num = rn.Next(4);

            }

        }

       
    }
}