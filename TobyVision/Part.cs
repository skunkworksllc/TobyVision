using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TobyVision
{
    class Part
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }
        //Probably will just do two clasifiers (i.e. Steel / Alumumum)
        //I don't forsee the computer being able to tell the difference in 4140 & 4142HT
        public string Material { get; set; }
        public string Job { get; set; }
        public string Detail { get; set; }


        public Part() { }

        public Part(Point a, Point b, Point c, Point d, string Material, string Job, string Detail)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.Material = Material;
            this.Job = Job;
            this.Detail = Detail;
        }

        public double GetRotation()
        {
            return 0;
        }

        public Point GetXYSize()
        {
            return new Point();
        }
    }
}
