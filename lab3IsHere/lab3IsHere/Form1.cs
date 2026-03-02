using classOfLab3;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab3IsHere
{
    public partial class Form1 : Form
    {
        public Graphics graph;
        public Pen pen1, pen2;
        public Brush hatchBrush, clearBrush;

        public Form1()
        {
            InitializeComponent();

            graph = this.CreateGraphics();
            pen1 = new Pen(Color.Black, 2);
            pen2 = new Pen(this.BackColor, 2);
            hatchBrush = new HatchBrush(HatchStyle.Horizontal, Color.Black, Color.Transparent);
            clearBrush = new SolidBrush(this.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentNumber = Wigwam.WigwamCount + 1;
            int current_a = 50 + currentNumber * 20;
            int current_H = 80 + currentNumber * 30;
            int current_h = 30 + currentNumber * 10;

            Point position = new Point(50 + currentNumber * 100, 300);

            Wigwam newWigwam = new Wigwam(current_a, current_H, current_h, position, this);
        }
    }
}