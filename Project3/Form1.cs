namespace Project3
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private int margin = 40;
        private int sizeNun = 30; // ������ ���� 
        private int sizeDol = 28;
        private bool isBlack = true;
        enum STONE {none, black, white } // ������� 0,1,2
        STONE[,] dataSet = new STONE[19, 19];

        public Form1()
        {
            InitializeComponent();

            // �׷��� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            // �ٵ��� ��, ũ��
            this.BackColor = Color.Orange;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;


            // Console.WriteLine($"x: {x}, y: {y}"); // Ŭ���� ��ǥ �� �� ���� 
            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);   // �簢���̱� ������



            // ���� �����ִ��� Ȯ��
            if (dataSet[x, y] != STONE.none)
            {
                MessageBox.Show("���� ������ �ֽ��ϴ�.");
                return;
            }



            // ������, �� �׸���
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

            // ���� ����
            CheckOmok(x, y);
        }


        // �� ���� ��������
        public void CheckOmok(int x, int y) // �Ű����� x, y
        {
            int count = 1;

            // ������
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

          
            // ����
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

            // ����
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

            // �Ʒ���
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

            // 11��
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


            // 16��
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

            // 13��
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

            // 19 ��
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
            Console.WriteLine("ī��Ʈ: " + count);
            
      
   }

        public void CheckCountResult(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("�����Դϴ�! ���ο� ������ �����ұ��?",
                    "Ȯ��",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                        //  �� �ݱ�
                        this.Close();

                }
            }

        }

        public void NewGame()
        {
            //ȭ�� ����
            this.Invalidate(); // Onpaint ȣ��!

            // dataSet �ʱ�ȭ
            for(int x = 0; x<19; x++)
            {
                for(int y=0; y<19; y++)
                {
                    dataSet[x, y] = STONE.none;
                }
            }
            // ������ ����
            isBlack = true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                // ������
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
                // ������
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
            }

           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 0), new Point(margin+ 18 * sizeNun, margin + sizeNun * 0)); // 19���̱� ������
           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 1), new Point(margin+ 18 * sizeNun, margin + sizeNun * 1)); // 19���̱� ������
           // g.DrawLine(pen, new Point(margin,margin + sizeNun * 2), new Point(margin+ 18 * sizeNun, margin + sizeNun * 2)); 

        }





    }
}