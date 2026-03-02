using lab3IsHere;
using System;
using System.Drawing;

namespace classOfLab3
{
    public class Wigwam
    {
        public static int WigwamCount = 0;
        public int a;
        public int H;
        public int h;
        public Point bottomCenter;
        public Form1 form;

        public Wigwam()
        {
            this.a = 0;
            this.H = 0;
            this.h = 0;
        }

        public Wigwam(int a, int H, int h, Point bottomCenter, Form1 form1)
        {
            WigwamCount++;

            this.a = a;
            this.H = H;
            this.h = h;
            this.bottomCenter = bottomCenter;
            this.form = form1;
        }

        public void Draw(Pen pen, Brush brush, Graphics graph)
        {
            if (a == 0 && H == 0 && h == 0) return;

            Point p1 = new Point(bottomCenter.X - a / 2, bottomCenter.Y);
            Point p2 = new Point(bottomCenter.X, bottomCenter.Y - H);
            Point p3 = new Point(bottomCenter.X + a / 2, bottomCenter.Y);
            Point p4 = new Point(bottomCenter.X, bottomCenter.Y - h);

            Point[] points = { p1, p2, p3, p4 };
            graph.FillPolygon(brush, points);
            graph.DrawPolygon(pen, points);
        }

        public void Show() { Draw(form.pen1, form.hatchBrush, form.graph); }
        public void Hide() { Draw(form.pen2, form.clearBrush, form.graph); }
    }
}