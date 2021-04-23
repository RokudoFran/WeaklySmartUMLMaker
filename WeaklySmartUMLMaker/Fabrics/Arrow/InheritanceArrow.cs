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
        public InheritanceArrow()
        {
        }
        public override void Draw()
        {
            Holst holst = Holst.GetHolst();
            var pen = new Pen(Color, Width);
            var gr = holst.holstGraphics;


            int width = 15;
            int height = 24;

            float d = Convert.ToSingle(Math.Sqrt(Math.Pow(FinishPoint.X - StartPoint.X, 2) + Math.Pow(FinishPoint.Y - StartPoint.Y, 2)));

            float X = FinishPoint.X - StartPoint.X;
            float Y = FinishPoint.Y - StartPoint.Y;

            float X3 = FinishPoint.X - (X / d) * height;
            float Y3 = FinishPoint.Y - (Y / d) * height;

            float Xp = FinishPoint.Y - StartPoint.Y;
            float Yp = StartPoint.X - FinishPoint.X;

            float X4 = X3 + (Xp / d) * width;
            float Y4 = Y3 + (Yp / d) * width;
            float X5 = X3 - (Xp / d) * width;
            float Y5 = Y3 - (Yp / d) * width;
            float X1 = StartPoint.X;
            float Y1 = StartPoint.Y;
            float X2 = FinishPoint.X;
            float Y2 = FinishPoint.Y;
            X2 = X3;
            Y2 = Y3;
            gr.DrawLine(pen, X1, Y1, X2, Y2);


            X1 = FinishPoint.X;
            Y1 = FinishPoint.Y;
            X2 = X4;
            Y2 = Y4;
            gr.DrawLine(pen, X1, Y1, X2, Y2);
            float xl = X2;
            float yl = Y2;

            X1 = FinishPoint.X;
            Y1 = FinishPoint.Y;
            X2 = X5;
            Y2 = Y5;
            gr.DrawLine(pen, X1, Y1, X2, Y2);
            gr.DrawLine(pen, xl, yl, X2, Y2);
        }

    }
}
