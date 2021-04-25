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
    public class Collection : AbstructFigure
    {
        private Brush Brush { get; set; }

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        public Collection()
        {
        }

        public override void Draw()
        {
            Holst holst = Holst.GetHolst();
            var pen = new Pen(Color, Width);
            var gr = holst.holstGraphics;
            //gr.DrawRectangle(pen, )
            gr.FillRectangle(whiteBrush, StartPoint.X, StartPoint.Y, (FinishPoint.X - StartPoint.X), (FinishPoint.Y - StartPoint.Y));
            gr.DrawRectangle(pen, StartPoint.X, StartPoint.Y, (FinishPoint.X - StartPoint.X), (FinishPoint.Y - StartPoint.Y));
            
            int startX = StartPoint.X + 15;
            int startY = StartPoint.Y - 15;
            int finishX = FinishPoint.X + 15;
            int finishY = FinishPoint.Y - 15;
            
            
            gr.FillRectangle(whiteBrush, startX, startY, (finishX - startX), (finishY - startY));
            gr.DrawRectangle(pen, startX, startY, (finishX - startX), (finishY - startY));

            startX = startX + 15;
            startY = startY - 15;
            finishX = finishX + 15;
            finishY = finishY - 15;

            gr.FillRectangle(whiteBrush, startX, startY, (finishX - startX), (finishY - startY));
            gr.DrawRectangle(pen, startX, startY, (finishX - startX), (finishY - startY));

        }
    }
}
