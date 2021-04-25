using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaklySmartUMLMaker
{
    public static class FindFigure
    {
        public static bool findFigure(Point point, AbstructFigure figure)
        {
            int xMax;
            int yMax;
            int xMin;
            int yMin;

            if (figure.StartPoint.X > figure.FinishPoint.X)
            {
                xMax = figure.StartPoint.X;
                xMin = figure.FinishPoint.X;
            }
            else
            {
                xMin = figure.StartPoint.X ;
                xMax = figure.FinishPoint.X;
            }

            if (figure.StartPoint.Y > figure.FinishPoint.Y)
            {
                yMax = figure.StartPoint.Y;
                yMin = figure.FinishPoint.Y;
            }
            else
            {
                yMin = figure.StartPoint.Y ;
                yMax = figure.FinishPoint.Y;
            }


            if (figure.StartPoint.X <= xMax && figure.StartPoint.X >= xMin && figure.StartPoint.X <= yMax && figure.StartPoint.X >= yMin)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
