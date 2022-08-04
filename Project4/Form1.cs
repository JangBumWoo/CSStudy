namespace Project4
{
    public partial class Form1 : Form
    {

        // �׷��� ��ü ���� (���� ���� X)
        Graphics g;
        Brush racketBrush = new SolidBrush(Color.Red);
        Brush blockBrush = new SolidBrush(Color.Orange);
        Brush ballBrush = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);
        
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball = new Rectangle();

        int nBlock = 20;
       
        int racketW = 50; // ����ũ��
        int racketH = 10;
        int racketY = 480;

        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        int ballW = 10;
        int ballH = 10;

        double slope = 0; // �� ����
        double dir = 0; // �ö󰡴� �������� �������� �������� �� ���� 

        bool[] blockVisible = new bool[100];


        Random rand = new Random(); // �ʱ�ȭ


        public Form1()
        {
            InitializeComponent();

            // �� ������
            this.ClientSize = new Size(300, 500);
            this.Text = "�������� v1.0";
 


            // �׷��� ��ü ���� (������)
            g = this.CreateGraphics();

            // ��� �ʱ�ȭ
            InitBLock();

            // ���� �ʱ�ȭ
            InitRacket();

            // �� �ʱ�ȭ
            InitBall(); 



        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� �׸���

            for (int i = 0; i < 20; i++)
            {
                if (blockVisible[i])
                g.FillRectangle(blockBrush, blocks[i]);
           
            }

            // ���� �׸���
            g.FillRectangle(racketBrush, racket);

            // �� �׸��� 
            g.FillEllipse(ballBrush, ball);
            g.DrawEllipse(pen, ball);
        }


        public void InitBLock() 
        {
           // blocks[0] = new Rectangle(blockW * 0, blockY + blockH * 0, blockW-1, blockH-1); // blockY + blockH: �� ����
           // blocks[1] = new Rectangle(blockW * 1, blockY + blockH * 0, blockW-1, blockH-1);
           // blocks[2] = new Rectangle(blockW *2, blockY + blockH * 0, blockW-1, blockH-1);
      
            for (int i=0; i < nBlock; i++)
            {
                blocks[i] = new Rectangle(blockW * (i % 10), 
                    blockY + blockH * (i / 10), // 10���ʹ� �ٽ� ����
                    blockW - 1, 
                    blockH - 1);
                blockVisible[i] = true;
            }

            // ���� �ʱ�ȭ
            slope = rand.Next(1, 20) / 10.0 ; // ���� ���� 1~9

            if(rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }

            dir = 1; // ������ 
        
        }

        public void InitRacket() 
        {
            racket.X = this.Width / 2 - racketW / 2; // X ��ǥ: ���� ���߾� 
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;


        }
        
        public void InitBall() 
        {
            ball.X =  this.Width / 2 - ballW / 2;
            ball.Y = ballH + blockY * 2;
            ball.Width = ballW;
            ball.Height = ballH;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mtTimer_Tick(object sender, EventArgs e)
        {
            // 1000�̹Ƿ� 1�ʸ��� ����
            // Console.WriteLine("Tick!");
            double dx = ballW / slope;
            double dy = Math.Abs(ballH * slope) * dir; // ���� ���̷�

            int x = (int)dx;
            int y = (int)dy;

            ball.Y += y;
            ball.X += x;
            
            // ball�� �¿� ���� �浹���� ��
            if(ball.X <= 0 || ball.X >= this.Width - ballW) // ���� ũ�� �� �� ������
            {
                slope = -slope;
            }

            // ball�� ������ �浹���� ��
            if (ball.Y < 10 || racket.IntersectsWith(ball))
            {
                dir = -dir;
            }



            // ball�� ������ �浹���� �� 

            for (int i=0; i<nBlock; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
            }


            // ball�� ������ ��
            if (ball.Y > this.Height)
            {
                mtTimer.Stop();

                MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��",
                    MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    InitBLock();
                    InitBall();
                    InitRacket();

                    mtTimer.Start();
                }
                else
                {
                    this.Close();
                }

            }

            // ��� block�� ���� ��
            


            // ball�� y ��ǥ�� �ٲ���� ������ �ٽ� �׷��� �� (OnPaint ȣ��)
            this.Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= racketW;
            }

            if (e.KeyCode == Keys.Right)
            {
                racket.X += racketW;
            }
        }
    }
}