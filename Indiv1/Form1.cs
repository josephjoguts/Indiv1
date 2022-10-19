using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indiv1
{
    public partial class Form1 : Form
    {
        private Graphics canvas;
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Pen blackPen = new Pen(Color.Black, 3);
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            canvas = canvasBox.CreateGraphics();
            
        }

        private void canvasBox_MouseClick(object sender, MouseEventArgs e)
        {
            canvas.FillEllipse(blackBrush,e.X-3,e.Y-3,7,7);
            points.Add(e.Location);
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            clear.Enabled = false;
            List<Point> hull = new List<Point>();
            Point vPointOnHull = points.Where(p => p.X == points.Min(min => min.X)).First();
            
            Point vEndpoint;
            do
            {
                hull.Add(vPointOnHull);
                vEndpoint = points[0];

                for (int i = 1; i < points.Count; i++)
                {
                    if ((vPointOnHull == vEndpoint)
                        || (Orientation(vPointOnHull, vEndpoint, points[i]) == -1))
                    {
                        vEndpoint = points[i];
                    }
                }
                canvas.DrawLine(blackPen, vPointOnHull, vEndpoint);
                Thread.Sleep(1000);
                vPointOnHull = vEndpoint;

            }
            while (vEndpoint != hull[0]);
            start.Enabled = true;
            clear.Enabled = true;
        }

        private static int Orientation(Point p1, Point p2, Point p)
        {
            // Determinant
            int Orin = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);

            if (Orin > 0)
                return -1; //          (* Orientation is to the left-hand side  *)
            if (Orin < 0)
                return 1; // (* Orientation is to the right-hand side *)

            return 0; //  (* Orientation is neutral aka collinear  *)
        }

        private void clear_Click(object sender, EventArgs e)
        {
            canvasBox.Image = new Bitmap(1300, 900);
            points.Clear();
        }
    }
}