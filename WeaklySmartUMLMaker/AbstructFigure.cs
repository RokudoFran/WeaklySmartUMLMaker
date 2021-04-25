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
    public abstract class AbstructFigure : IAction
    {
        public Point StartPoint { get; set; }

        public Point FinishPoint { get; set; }

        public Color AbsColor { get; set; }

        public int AbsWidth { get; set; }


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

        public bool findFigure(Point point)
        {
            int xMax;
            int yMax;
            int xMin;
            int yMin;

            if(StartPoint.X > FinishPoint.X)
            {
                xMax = StartPoint.X;
                xMin = FinishPoint.X;
            }
            else
            {
                xMin = StartPoint.X;
                xMax = FinishPoint.X;
            }

            if (StartPoint.Y > FinishPoint.Y)
            {
                yMax = StartPoint.Y;
                yMin = FinishPoint.Y;
            }
            else
            {
                yMin = StartPoint.Y;
                yMax = FinishPoint.Y;
            }


            if (StartPoint.X <= xMax && StartPoint.X >= xMin && StartPoint.X <= yMax && StartPoint.X >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        void Move(int deltaX, int deltaY)
        {
            
        }

        public abstract void Draw(); 
    }
}