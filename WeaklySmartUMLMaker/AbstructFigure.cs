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

        public AbstructFigure()
        {
          
        }

        public abstract void Draw(Point start, Point finish);
    }

}
