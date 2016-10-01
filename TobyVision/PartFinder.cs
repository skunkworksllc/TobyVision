using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TobyVision
{
    class PartFinder
    {
        Bitmap image;
        byte[,] bArray;
        List<Point> EdgePoints;
        public PartFinder(Bitmap image)
        {
            this.image = image;
        }

        public bool FindParts(ref List<Part> parts)
        {
            bArray = GetByteArrayFromBitmap(ref image);
            return false;
        }

        public byte[,] GetByteArrayFromBitmap(ref Bitmap bm)
        {
            byte[,] ba = new byte[bm.Width, bm.Height];
            Convert1(ref bm, ref ba);
            return ba;
        }

        //bool return is success of failure
        //3 conversion algorithms this is where the magic happens
        private bool Convert1(ref Bitmap bm, ref byte[,] ba)
        {
            //implement me
            FindEdgePoints(new Bitmap(bm, bm.Width, bm.Height), ref EdgePoints);
            return true;
        }

        private bool Convert2(ref Bitmap bm, ref byte[,] ba)
        {
            return true;
        }

        private bool Convert3(ref Bitmap bm, ref byte[,] ba)
        {
            return true;
        }

        public List<Part> FindPerimetersFromByteArray(ref byte[,] ba)
        {
            return new List<Part>();//implement me
        }

        public void FindEdgePoints(Bitmap bm, ref List<Point> points)
        {
            int threshold = 30;            
            Color c_clr, u_clr, b_clr;
            int u = bm.Width, v = bm.Height;
            points = new List<Point>();
            for (int y = 1; y < v; y++) //start at 1 so we can dialate
                for (int x = 1; x < u; x++)
                {
                    c_clr = bm.GetPixel(x, y);
                    u_clr = bm.GetPixel(x, y - 1);
                    b_clr = bm.GetPixel(x - 1, y);
                    if (RGBExtends(c_clr, b_clr, threshold) || 
                       (RGBExtends(c_clr, b_clr, threshold)))              
                        points.Add(new Point(x, y));  
                }                
        }

        private static bool RGBExtends(Color c1, Color c2, int threshold)
        {
            int r1 = c1.R, g1 = c1.G, b1 = c1.B;
            int r2 = c2.R, g2 = c2.G, b2 = c2.B;
            return (threshold < System.Math.Sqrt(((r1 - r2) * (r1 - r2)) + ((g1 - g2) * (g1 - g2)) + ((b1 - b2) * (b1 - b2))));
        }

        public List<Point> GetEdgePoints() { return EdgePoints; }


    }
}
