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
    public class InheritanceArrow : AbstructFigure
    {
        public InheritanceArrow(Pen pen, Graphics graphics)
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
            X2 = X3;
            Y2 = Y3;
            Graphics.DrawLine(Pen, X1, Y1, X2, Y2);


            X1 = finish.X;
            Y1 = finish.Y;
            X2 = X4;
            Y2 = Y4;
            Graphics.DrawLine(Pen, X1, Y1, X2, Y2);
            float xl = X2;
            float yl = Y2;

            X1 = finish.X;
            Y1 = finish.Y;
            X2 = X5;
            Y2 = Y5;
            Graphics.DrawLine(Pen, X1, Y1, X2, Y2);
            Graphics.DrawLine(Pen, xl, yl, X2, Y2);
        }

    }
}
