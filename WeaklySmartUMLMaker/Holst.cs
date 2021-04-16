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
   public class Holst
   {
        public static Graphics holstGraphics { get; set; }

        public static Pen holstPen { get; set; }

        private Bitmap _tmpBitmap;
        private Bitmap _mainBitmap;
        private PictureBox _pictureBox;
        private static Holst _holst;

        private Holst()
        {
            holstPen = new Pen(Color.Black, 3);
        }

        public void SetPictureBox(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            holstGraphics = Graphics.FromImage(_tmpBitmap);
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpBitmap;
        }

       

        public static Holst GetHolst()
        {
            if(_holst is null)
            {
                _holst = new Holst();
            }

            return _holst;
        }

        public void GetGraphics()
        {
            Trace.WriteLine("GetGraphics");
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            holstGraphics = Graphics.FromImage(_tmpBitmap);
            //GC.Collect();
            //GC.SuppressFinalize(this);
            //GC.Collect();
            //holstGraphics.Clear(Color.White);
        }

        public void UpdateBitmap()
        {
            Trace.WriteLine("Update");
            _mainBitmap = _tmpBitmap;
            _pictureBox.Image = _mainBitmap;
            //_tmpBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
        }

        public void UpdatePictureBox()
        {
            Trace.WriteLine("UpdatePictureBox");
            holstGraphics.DrawImage(_tmpBitmap, 0, 0);
    
            _pictureBox.Image = _tmpBitmap;
        }

        public void Clear()
        {
            _mainBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _tmpBitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _pictureBox.Image = _mainBitmap;
        }
   }
}

