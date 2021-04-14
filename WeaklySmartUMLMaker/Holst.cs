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
   public class Holst
    {
        private static Holst _holst;

        private Holst()
        {

        }

        public static Holst Instanse
        {
            get
            {
                if (_holst == null)
                    _holst = new Holst();
                return _holst;
            }
        }


        public Pen Pen { get; set; }
        public Graphics Graphics { get; set; }


    }
}

