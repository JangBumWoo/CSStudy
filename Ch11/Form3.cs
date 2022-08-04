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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 80, 100, 100); // x,y,w,h 좌표 가로 100 세로 100 사각형 
            g.DrawRectangle(blackPen, rect);
            g.FillRectangle(redBrush, rect);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush blueBrush = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 80, 100, 100); // x,y,w,h 좌표 가로 100 세로 100
            g.DrawEllipse(blackPen, rect);
            g.FillEllipse(blueBrush, rect);

        }

        private void button3_Click(object sender, EventArgs e) // 선출력
        {
            Graphics g = this.CreateGraphics();      
            Pen blackPen = new Pen(Color.Black);
            
            g.DrawLine(blackPen, new Point(320, 80), new Point(320, 80)); // 점과 점 연결 
        }
    }
}
