using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.LifeCam;
using System.Drawing.Imaging;


using System.Timers;

namespace TobyVision
{
    public partial class TobyVision : Form
    {
        PartFinder pf;
        System.Windows.Forms.Timer CheckTimer;   
        List<Part> parts;
        MVCamera cam;
        List<Point> PointsList;
        Result res;
        public TobyVision()
        {
            InitializeComponent();
            PointsList = new List<Point>();
            Init();
        }


        private void Init()
        {
            try
            {
                cam = new MVCamera(this);
                if (!cam.SeemsGoodToGo())
                {
                    MessageBox.Show("No Camera Found! Cannot Start!");
                    return; 
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            CheckTimer = new System.Windows.Forms.Timer();//new System.Timers.Timer();
            CheckTimer.Interval = 1000;
            CheckTimer.Tick += new EventHandler(CheckTimerTick);//Elapsed += new ElapsedEventHandler(CheckTimerTick);
            GetMVDevice();
            res = new Result(PointsList);            
        }


        private void CheckTimerTick(object source, EventArgs e) { Analyze(); }


        private void GetMVDevice(){; }

        private void Analyze()
        {
            
            Bitmap frame = cam.GetBitmap();
            pbViewer.Image = frame;
            Application.DoEvents();
                
            pf = new PartFinder(frame);
            parts = new List<Part>();
            if (pf.FindParts(ref parts))  
            {
            //    CheckTimer.Stop();
            //    MessageBox.Show("Found Parts!");
            }
           // PointsList = pf.GetEdgePoints();
            button1_Click(this, new EventArgs());
        }

        private Bitmap GrabBitMap()
        {
            return new Bitmap(1, 1);
        }

        public void DisplayMessage(string msg) { MessageBox.Show(msg, this.Name); }

        private void scanningYNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scanningYNToolStripMenuItem.Checked)
            {
                scanningYNToolStripMenuItem.Checked = false;
                CheckTimer.Enabled = false;
            }
            else
            {
                scanningYNToolStripMenuItem.Checked = true;
                CheckTimer.Enabled = true;
            }

        }

        private void TobyVision_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckTimer.Enabled = false;
            cam.Trash();
        }

        
        //test

        public void DrawRectangle(object sender, PaintEventArgs e)
        {
            //if(PointsList.Count > 0)
            //{
            //    foreach (Point p in pf.GetEdgePoints())
            //    {
            //        DrawPoint(p, new Pen(Color.Red, 2), e.Graphics, 2);
            //    }
            //}
            //foreach(Point p in pf.GetEdgePoints())
            //{
            //    DrawPoint(p, new Pen(Color.Red, 2), e.Graphics, 2);                
            //}
            //Rectangle ee = new Rectangle(10, 10, 30, 30);
            //using (Pen pen = new Pen(Color.Red, 2))
            //{
            //    e.Graphics.DrawRectangle(pen, ee);
            //}

        }


        private void DrawPoint(Point p, Pen pen, Graphics g, int size)
        {
            g.DrawLine(pen, p, p);
            Point corner = new Point(p.X - (size / 2) , p.Y - (size / 2) );
            Rectangle bound = new Rectangle(corner, new Size(size, size));
            g.DrawEllipse(pen, bound);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap frame = cam.GetBitmap();
            pbViewer.Image = frame;
            PartFinder pf = new PartFinder(new Bitmap(1, 1));
            pf.FindEdgePoints(frame, ref PointsList);
            //foreach (Point p in PointsList)
             //   DrawPoint(p, new Pen(Color.Red, 2), pbViewer.CreateGraphics(), 2);
            //Result res = new Result(PointsList);
            //res.ShowDialog();
            if(!res.Visible)
                res.ShowDialog();
            res.PaintList(PointsList);
        }


    }

    
}
