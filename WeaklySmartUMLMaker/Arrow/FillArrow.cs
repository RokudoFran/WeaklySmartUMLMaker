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
    public class FillArrow : AbstructFigure
    {
        public FillArrow()
            : base(pen, graphics)
        {
        }

        public override void Draw(Point start, Point finish)
        {
            int width = 15;
            int height = 12;

            .CustomEndCap = new AdjustableArrowCap(width, height);
            Graphics.DrawLine(Pen, start.X, start.Y, finish.X, finish.Y);

        }
    }
}
