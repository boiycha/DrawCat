
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCat(e.Graphics);
        }

        private void DrawCat(Graphics graphics)
        {
            graphics.Clear(Color.White);
            SolidBrush ear = new SolidBrush(Color.DarkGray);
            Point point1 = new Point(Width / 3, Height / 3 + 15); // низ
            Point point2 = new Point(Width * 10 / 24 + 2, Height * 6 / 24 + 25); // право
            Point point3 = new Point(Width * 8 / 24, Height * 6 / 24 + 15); // верх 
            Point[] ear1 = { point1, point2, point3 };
            graphics.FillPolygon(ear, ear1);
            Point p4 = new Point(Width * 4 / 6 - 20, Height / 3 + 17); // низ
            Point p5 = new Point(Width * 14 / 24 - 18, Height * 6 / 24 + 25); // лево
            Point p6 = new Point(Width * 16 / 24 - 18, Height * 6 / 24 + 15); // верх
            Point[] ear2 = { p4, p5, p6 };
            graphics.FillPolygon(ear, ear2);
            graphics.FillEllipse(ear, Width / 12 + 92, Height / 12 + 97, Width * 4 / 11, Height * 4 / 11);

            SolidBrush foreyes = new SolidBrush(Color.White);
            graphics.FillEllipse(foreyes, Width / 3 + 10, Height * 3 / 8 + 10, Width / 24 + 20, Height / 24);
            graphics.FillEllipse(foreyes, Width / 3 + 80, Height * 3 / 8 + 10, Width / 24 + 20, Height / 24);

            graphics.FillEllipse(new SolidBrush(Color.Black), Width / 3 + 19, Height * 3 / 8 + 10, Width / 24, Height / 24);
            graphics.FillEllipse(new SolidBrush(Color.Black), Width / 3 + 89, Height * 3 / 8 + 10, Width / 24, Height / 24);


            Point point4 = new Point(Width / 3 + 50, Height / 3 + 60); // лево 
            Point point5 = new Point(Width / 3 + 80, Height / 3 + 60); // право
            Point point6 = new Point(Width / 3 + 65, Height / 3 + 75); // низ
            Point[] nose = { point4, point5, point6 };
            graphics.FillPolygon(new SolidBrush(Color.Black), nose);

            graphics.FillEllipse(new SolidBrush(Color.Pink), Width * 4 / 9 - 5, Height * 13 / 28 + 30, Width / 10, Height / 15);
            graphics.FillEllipse(new SolidBrush(Color.White), Width * 4 / 9 - 21, Height * 13 / 28 + 20, Width / 10, Height / 15);
            graphics.FillEllipse(new SolidBrush(Color.White), Width * 4 / 9 + 15, Height * 13 / 28 + 20, Width / 10, Height / 15);

            graphics.DrawLine(new Pen(Color.Black, 3), 140, 210, 190, 240);
            graphics.DrawLine(new Pen(Color.Black, 3), 140, 230, 190, 245);
            graphics.DrawLine(new Pen(Color.Black, 3), 140, 245, 190, 250);
            graphics.DrawLine(new Pen(Color.Black, 3), 225, 240, 275, 210);
            graphics.DrawLine(new Pen(Color.Black, 3), 225, 245, 275, 230);
            graphics.DrawLine(new Pen(Color.Black, 3), 225, 250, 275, 245);
        }
    }
}


