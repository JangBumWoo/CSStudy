namespace Project3
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private int margin = 40;
        private int sizeNun = 30; // 선과의 간격 
        private int sizeDol = 28;
        private bool isBlack = true;
        enum STONE {none, black, white } // 순서대로 0,1,2
        STONE[,] dataSet = new STONE[19, 19];

        public Form1()
        {
            InitializeComponent();

            // 그래픽 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            // 바둑판 색, 크기
            this.BackColor = Color.Orange;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;


            // Console.WriteLine($"x: {x}, y: {y}"); // 클릭시 좌표 알 수 있음 
            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);   // 사각형이기 때문에



            // 돌이 놓여있는지 확인
            if (dataSet[x, y] != STONE.none)
            {
                MessageBox.Show("돌이 놓여져 있습니다.");
                return;
            }



            // 검은돌, 흰돌 그리기
            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x, y] = STONE.black;
                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;
                isBlack = true;
            }

            // 오목 판정
            CheckOmok(x, y);
        }


        // 돌 놓고 오목판정
        public void CheckOmok(int x, int y) // 매개변수 x, y
        {
            int count = 1;

            // 오른쪽
            for(int i = x + 1; i<x+5; i++)
            {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }

          
            // 왼쪽
            for (int i = x - 1; i < x - 5; i--)
            {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            CheckCountResult(count);
            count = 1;

            // 위쪽
            for (int i = y + 1; i < y + 5; i++)
            {
                if (dataSet[x, y] == dataSet[x, i])
                { 
                    count++;
                }
                else
                {
                    break;
                }

            }
            count = 1;

            // 아래쪽
            for (int i = y - 1; i < y - 5; i--)
            {
                if (dataSet[x, y] == dataSet[x, i])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            CheckCountResult(count);
            count = 1;

            // 11시
            for (int i = x - 1, j = y -1; i >=0 && j >=0; j--, i--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }


            // 16시
            for (int i = x + 1, j = y + 1; i < 19 && j < 19; j++, i++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            CheckCountResult(count);
            count = 1;

            // 13시
            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }

            // 19 시
            for (int i = x - 1, j = y + 1; j < 19 && i >= 0; i--, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }

            }
            CheckCountResult(count);
            count = 1;
            Console.WriteLine("카운트: " + count);
            
      
   }

        public void CheckCountResult(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?",
                    "확인",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                        //  폼 닫기
                        this.Close();

                }
            }

        }

        public void NewGame()
        {
            //화면 갱신
            this.Invalidate(); // Onpaint 호출!

            // dataSet 초기화
            for(int x = 0; x<19; x++)
            {
                for(int y=0; y<19; y++)
                {
                    dataSet[x, y] = STONE.none;
                }
            }
            // 검은돌 시작
            isBlack = true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                // 가로줄
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
                // 세로줄
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
            }

           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 0), new Point(margin+ 18 * sizeNun, margin + sizeNun * 0)); // 19줄이기 때문에
           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 1), new Point(margin+ 18 * sizeNun, margin + sizeNun * 1)); // 19줄이기 때문에
           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 2), new Point(margin+ 18 * sizeNun, margin + sizeNun * 2)); 

        }





    }
}