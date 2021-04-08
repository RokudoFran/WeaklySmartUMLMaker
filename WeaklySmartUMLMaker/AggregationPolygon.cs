using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaklySmartUMLMaker
{
    public class AggregationPolygon : AbstructFigure
    {
        public AggregationPolygon(Pen pen, Graphics graphics)
            : base(pen, graphics)
        {
        }
        public override void Draw(Point start, Point finish)
        {
            int width = 15;
            int height = 24;

            float d = Convert.ToSingle(Math.Sqrt(Math.Pow(finish.X - start.X, 2) + Math.Pow(finish.Y - start.Y, 2)));

            float X = finish.X - start.X;
            float Y = finish.Y - start.Y;

            float X3 = finish.X - (X / d) * height;
            float Y3 = finish.Y - (Y / d) * height;
            float X6 = finish.X - (X / d) * height * 2;
            float Y6 = finish.Y - (Y / d) * height * 2;

            float Xp = finish.Y - start.Y;
            float Yp = start.X - finish.X;

            float X4 = X3 + (Xp / d) * width;
            float Y4 = Y3 + (Yp / d) * width;
            float X5 = X3 - (Xp / d) * width;
            float Y5 = Y3 - (Yp / d) * width;
            float X1 = start.X;
            float Y1 = start.Y;
            float X2 = finish.X;
            float Y2 = finish.Y;
            Graphics.DrawLine(Pen, X1, Y1, Convert.ToInt32(X6), Convert.ToInt32(Y6));
            //pen.DashStyle = DashStyle.Solid; 

            Point point1 = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
            Point point2 = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
            Point point3 = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
            Point point4 = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
            Point[] curvePoints = { point1, point2, point3, point4 };

            // Draw polygon to screen. 
            Graphics.DrawPolygon(Pen, curvePoints);
        }
    }
}
