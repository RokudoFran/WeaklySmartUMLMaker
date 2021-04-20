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
    public abstract class AbstructFigure
    {
        public Point StartPoint { get; set; }
        public Point FinishPoint { get; set; }

        public AbstructFigure()
        {
            StartPoint = new Point();
            FinishPoint = new Point();
        }
        public AbstructFigure(Point start, Point finish)
        {
            StartPoint = start;
            FinishPoint = finish;
        }

        public abstract void Draw();

        //internal abstract void Draw();
    }


}