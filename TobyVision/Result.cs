using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TobyVision
{
    public partial class Result : Form
    {
        List<Point> PointList;
        public Result()
        {
            InitializeComponent();
        }

        public Result(List<Point> pList)
        {
            InitializeComponent();
            this.PointList = pList;
        }

        public void PaintList()
        {
            foreach (Point p in PointList)
                DrawPoint(p, new Pen(Color.Red, 2), this.CreateGraphics(), 2);
        }

        public void PaintList(List<Point> PointList)
        {
            foreach (Point p in PointList)
                DrawPoint(p, new Pen(Color.Red, 2), this.CreateGraphics(), 2);
        }

        private void DrawPoint(Point p, Pen pen, Graphics g, int size)
        {
            g.DrawLine(pen, p, p);
            Point corner = new Point(p.X - (size / 2), p.Y - (size / 2));
            Rectangle bound = new Rectangle(corner, new Size(size, size));
            g.DrawEllipse(pen, bound);
        }

        private void Result_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point p in PointList)
                DrawPoint(p, new Pen(Color.Red, 2), this.CreateGraphics(), 1);
        }


    }
}
