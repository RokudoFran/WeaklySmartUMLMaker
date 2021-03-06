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
        public Graphics holstGraphics { get; set; }

        public Pen holstPen { get; set; }

        public Color holstColor { get; set; }

        public int holstWidth { get; set; }

        public SolidBrush holstBrush { get; set; }

        private Bitmap _tmpBitmap;
        private Bitmap _mainBitmap;
        private Bitmap _newTmpBitmap;
        private PictureBox _pictureBox;
        private static Holst _holst;

        private Holst()
        {
            //holstPen = new Pen(Color.Black, 1);

            ////holstBrush = new Brush(Color.Black);
            holstBrush = new SolidBrush(Color.Black);

            holstColor = Color.Black;
            holstWidth = 1;
            holstPen = new Pen(holstColor, holstWidth);

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

        public void SaveBitmap()
        {
            _newTmpBitmap = (Bitmap)_mainBitmap.Clone();
            holstGraphics = Graphics.FromImage(_newTmpBitmap);
            //holstGraphics.Clear(Color.Red);
        }

        public void SavePictureBox()
        {
            _pictureBox.Image = _newTmpBitmap;
        }
    }
}

