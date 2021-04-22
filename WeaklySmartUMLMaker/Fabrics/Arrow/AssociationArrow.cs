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
    public class AssociationArrow : AbstructFigure
    {
        public AssociationArrow()
            
        {
        }
        public override void Draw()
        {
           
            Holst holst = Holst.GetHolst();
            var pen = new Pen(AbsColor, AbsWidth);
            var gr = holst.holstGraphics;

            int width = 15;
            int height = 24;

            //double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
            float d = Convert.ToSingle(Math.Sqrt(Math.Pow(FinishPoint.X - StartPoint.X, 2) + Math.Pow(FinishPoint.Y - StartPoint.Y, 2)));
            //float[] dashPattern = new float[2] { 5f, 5f }; 
            //pen.DashPattern = dashPattern; 

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
            gr.DrawLine(pen, X1, Y1, X2, Y2);
            //pen.DashStyle = DashStyle.Solid; 

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
        }
    }
}
