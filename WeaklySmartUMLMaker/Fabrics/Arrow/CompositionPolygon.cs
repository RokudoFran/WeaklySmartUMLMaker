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
    public class CompositionPolygon : AbstructFigure
    {
        private Brush Brush { get; set; }

        SolidBrush blackBrush = new SolidBrush(Color.Black);
        public CompositionPolygon()
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

            /*if (isDash == true) 
            { 
                float[] dashPattern = new float[2] { 5f, 5f }; 
                pen.DashPattern = dashPattern; 
            }*/

            float X = FinishPoint.X - StartPoint.X;
            float Y = FinishPoint.Y - StartPoint.Y;

            float X3 = FinishPoint.X - (X / d) * height;
            float Y3 = FinishPoint.Y - (Y / d) * height;
            float X6 = FinishPoint.X - (X / d) * height * 2;
            float Y6 = FinishPoint.Y - (Y / d) * height * 2;

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
            gr.DrawLine(pen, X1, Y1, X6, Y6);
            //pen.DashStyle = DashStyle.Solid; 

            Point point1 = new Point(Convert.ToInt32(X2), Convert.ToInt32(Y2));
            Point point2 = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
            Point point3 = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
            Point point4 = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
            Point[] curvePoints = { point1, point2, point3, point4 };

            // Draw polygon to screen. 
            //SolidBrush blackBrush = new SolidBrush(Color.Black);
            gr.FillPolygon(blackBrush, curvePoints);
        }
    }
}
