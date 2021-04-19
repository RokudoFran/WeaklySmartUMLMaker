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
    public class ArrowList
    {
        public Point firstPoint;
        public Point EndPoint;

        public ArrowList()
        {
            firstPoint = new Point();
            EndPoint = new Point();
        }
        public ArrowList(Point start, Point finish)
        {
            firstPoint = start;
            EndPoint = finish;
        }


    }
}