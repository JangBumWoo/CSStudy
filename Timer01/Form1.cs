namespace Timer01
{
    public partial class Form1 : Form
    {

        private Ball bl;
        private int dx, dy;


        class Ball
        {
            public Color Color;
            public Point Point;
        }

        public Form1()
        {
            InitializeComponent();

            this.Text = "타이머";
            this.ClientSize = new Size(250, 100);

            bl = new Ball();

            Point p = new Point(0, 0);
            Color c = Color.Blue;

            bl.Point = p;
            bl.Color = c;

            dx = 2;
            dy = 2;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point p = bl.Point;
            Color c = bl.Color;
            SolidBrush br = new SolidBrush(c);

            g.FillEllipse(br, p.X, p.Y, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tm_Tick(object sender, EventArgs e)
        {
            Point p = bl.Point;

            // 벽에 닿으면 반전
            if (p.X < 0 || p.X > this.ClientSize.Width - 10)
            {
                dx = -dx;
            }

            if (p.Y < 0 || p.Y > this.ClientSize.Height - 10)
            {
                dy = -dy;
            }

            // 이동
            p.X = p.X + dx;
            p.Y = p.Y + dy;

            bl.Point = p;
            this.Invalidate();
        }
    }
}