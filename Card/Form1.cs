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
        private int num; // ī�� ��ũ
        private bool isOpen; // ī�� �յ�

        public static void Main()
        {
            Application.Run(new Form1()); // ���� ���α׷� ���� 
        }

        public Form1()
        {
            this.Text = "ī��";
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

            isOpen = false; // ī�� �޸�
            Random rn = new Random(); // ī�� ��ũ ���� ���� 
            num = rn.Next(4); 

            pb.Click += new EventHandler(pb_Click); 

        }

       public void pb_Click(Object sender, EventArgs e) // ī�带 Ŭ������ ��
        {
            if (isOpen == false) // ī�尡 �ڸ�
            {
                isOpen = true; // ī�带 ������
                pb.Image = mim[num];

                if (rb[num].Checked == true) // ī�尡 ���� ���
                {
                    lb.ForeColor = Color.DeepPink; //ForeColor: ����� 
                    lb.Text = "HIT!";
                }
                else // ī�尡 ���� ���� ���
                {
                    lb.ForeColor = Color.SlateBlue;
                    lb.Text = "MISS!";
                }
            }
            
            else // ī�尡 ���̸�
            {
                isOpen = false; // ī�带 �ڷ�
                lb.Text = "";
                pb.Image = cim;

                Random rn = new Random(); // ���� ��ũ�� ��������
                num = rn.Next(4);

            }

        }

       
    }
}