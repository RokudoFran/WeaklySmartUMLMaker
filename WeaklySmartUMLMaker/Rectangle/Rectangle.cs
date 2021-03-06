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
            var pen = new Pen(AbsColor, AbsWidth);

            holst.holstGraphics.DrawRectangle(holst.holstPen,
                StartPoint.X, StartPoint.Y, (FinishPoint.X - StartPoint.X), (FinishPoint.Y - StartPoint.Y));
        }
    }
}
