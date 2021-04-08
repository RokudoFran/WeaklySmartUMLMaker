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
    public class CreateNewClass : AbstructFigure
    {
        public CreateNewClass(Pen pen, Graphics graphics)
                    : base(pen, graphics)
        {
        }

        public override void Draw(Point start, Point finish)
        {
            Graphics.DrawRectangle(Pen, start.X, start.Y, (finish.X - start.X), (finish.Y - start.Y));


            int y1 = (start.Y + finish.Y) / 2;

            int y2 = (start.Y + y1) / 2;

            int y3 = (y1 + finish.Y) / 2;


            Graphics.DrawLine(Pen, start.X, y1 , finish.X, y1);
            Graphics.DrawLine(Pen, start.X, y2, finish.X, y2);
            Graphics.DrawLine(Pen, start.X, y3, finish.X, y3);
            
        }
    }   
} 



