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

        public override void Draw(Point start, Point finish)
        {
            Holst.Instanse.Graphics.DrawRectangle(Holst.Instanse.Pen,
                start.X, start.Y, (finish.X - start.X), (finish.Y - start.Y));
        }
    }
}
