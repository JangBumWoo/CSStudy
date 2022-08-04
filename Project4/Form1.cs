namespace Project4
{
    public partial class Form1 : Form
    {

        // 그래픽 객체 선언 (아직 생성 X)
        Graphics g;
        Brush racketBrush = new SolidBrush(Color.Red);
        Brush blockBrush = new SolidBrush(Color.Orange);
        Brush ballBrush = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);
        
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball = new Rectangle();

        int nBlock = 20;
       
        int racketW = 50; // 라켓크기
        int racketH = 10;
        int racketY = 480;

        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        int ballW = 10;
        int ballH = 10;

        double slope = 0; // 공 기울기
        double dir = 0; // 올라가는 방향인지 내려가는 방향인지 그 여부 

        bool[] blockVisible = new bool[100];


        Random rand = new Random(); // 초기화


        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            this.ClientSize = new Size(300, 500);
            this.Text = "벽돌깨기 v1.0";
 


            // 그래픽 객체 생성 (생성자)
            g = this.CreateGraphics();

            // 블록 초기화
            InitBLock();

            // 라켓 초기화
            InitRacket();

            // 공 초기화
            InitBall(); 



        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기

            for (int i = 0; i < 20; i++)
            {
                if (blockVisible[i])
                g.FillRectangle(blockBrush, blocks[i]);
           
            }

            // 라켓 그리기
            g.FillRectangle(racketBrush, racket);

            // 공 그리기 
            g.FillEllipse(ballBrush, ball);
            g.DrawEllipse(pen, ball);
        }


        public void InitBLock() 
        {
           // blocks[0] = new Rectangle(blockW * 0, blockY + blockH * 0, blockW-1, blockH-1); // blockY + blockH: 위 여백
           // blocks[1] = new Rectangle(blockW * 1, blockY + blockH * 0, blockW-1, blockH-1);
           // blocks[2] = new Rectangle(blockW *2, blockY + blockH * 0, blockW-1, blockH-1);
      
            for (int i=0; i < nBlock; i++)
            {
                blocks[i] = new Rectangle(blockW * (i % 10), 
                    blockY + blockH * (i / 10), // 10부터는 다시 시작
                    blockW - 1, 
                    blockH - 1);
                blockVisible[i] = true;
            }

            // 기울기 초기화
            slope = rand.Next(1, 20) / 10.0 ; // 값의 범위 1~9

            if(rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }

            dir = 1; // 내려감 
        
        }

        public void InitRacket() 
        {
            racket.X = this.Width / 2 - racketW / 2; // X 좌표: 폼의 정중앙 
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
            // 1000이므로 1초마다 실행
            // Console.WriteLine("Tick!");
            double dx = ballW / slope;
            double dy = Math.Abs(ballH * slope) * dir; // 볼의 높이로

            int x = (int)dx;
            int y = (int)dy;

            ball.Y += y;
            ball.X += x;
            
            // ball이 좌우 벽에 충돌했을 때
            if(ball.X <= 0 || ball.X >= this.Width - ballW) // 볼의 크기 뺀 값 오른쪽
            {
                slope = -slope;
            }

            // ball이 라켓이 충돌했을 때
            if (ball.Y < 10 || racket.IntersectsWith(ball))
            {
                dir = -dir;
            }



            // ball이 벽돌에 충돌했을 때 

            for (int i=0; i<nBlock; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
            }


            // ball을 놓쳤을 때
            if (ball.Y > this.Height)
            {
                mtTimer.Stop();

                MessageBox.Show("다시 시작하시겠습니까?", "확인",
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

            // 모든 block을 깼을 때
            


            // ball의 y 좌표가 바뀌었기 때문에 다시 그려야 함 (OnPaint 호출)
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