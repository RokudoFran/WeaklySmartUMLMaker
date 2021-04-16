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
        public CreateNewClass()
                    : base()
        {
        }

        public override void Draw(Point start, Point finish)
        {
            var pen = Holst.holstPen;
            var gr = Holst.holstGraphics;

            gr.DrawRectangle(pen, start.X, start.Y, (finish.X - start.X), (finish.Y - start.Y));


            int y1 = (start.Y + finish.Y) / 2;

            int y2 = (start.Y + y1) / 2;

            int y3 = (y1 + finish.Y) / 2;


            gr.DrawLine(pen, start.X, y1 , finish.X, y1);
            gr.DrawLine(pen, start.X, y2, finish.X, y2);
            gr.DrawLine(pen, start.X, y3, finish.X, y3);
            
        }
    }   
} 



