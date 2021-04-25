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
    public class Rectangle : AbstructFigure
    {
        public Rectangle()
            : base()
        {
        }

        public override void Draw()
        {
            Holst holst = Holst.GetHolst();
            var pen = new Pen(Color, Width);
            var gr = holst.holstGraphics;

            gr.DrawRectangle(pen, StartPoint.X, StartPoint.Y, (FinishPoint.X - StartPoint.X), (FinishPoint.Y - StartPoint.Y));

            int y1 = (StartPoint.Y + FinishPoint.Y) / 2;

            int y2 = (StartPoint.Y + y1) / 2;

            gr.DrawLine(pen, StartPoint.X, y2, FinishPoint.X, y2);
        }
        
    }
}
