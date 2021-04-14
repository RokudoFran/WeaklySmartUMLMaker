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
            : base()
        {
        }

        public override void Draw(Point start, Point finish)
        {
            var pen = Holst.Instanse.Pen;
            var gr = Holst.Instanse.Graphics;

            int width = 15;
            int height = 12;

            pen.CustomEndCap = new AdjustableArrowCap(width, height);
            gr.DrawLine(pen, start.X, start.Y, finish.X, finish.Y);

        }
    }
}
