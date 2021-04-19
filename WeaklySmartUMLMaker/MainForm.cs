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
    public enum ActionType
    {
        Inheritance,
        Association,
        Realization,
        Composition,
        Aggregation,
        Rectangle,
        CreateNewClass
    }


    public partial class MainForm : Form
    {
        Point startPoint;
        ActionType _crntArrow;
        FigureFabric _fabric;
        Holst _holst;
        List<AbstructFigure> arrows;
        AbstructFigure _crnArrow;
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;




        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            arrows = new List<AbstructFigure>(); 
            _holst =Holst.GetHolst();
            _holst.SetPictureBox(pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            cretFabric();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _holst.GetGraphics();

                if (_fabric != null)
                {
                    _fabric.Draw(startPoint, e.Location);
                }

                _holst.UpdatePictureBox();
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _holst.UpdateBitmap();
            arrows.Add(_crnArrow);

        }

        private void cretFabric()
        {
            _fabric = FigureFabricCreator.GetFabric(_crntArrow);
        }

        
        private void buttonInheritance_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Inheritance;
        }

        private void buttonAssociation_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Association;
        }

        private void buttonRealization_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Realization;
        }

        private void buttonComposition_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Composition;
        }

        private void buttonAggregation_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Aggregation;
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.Rectangle;
        }

        private void CreateNewClassButton_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.CreateNewClass;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _holst.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            foreach (AbstructFigure a in arrows)
            {
                a.Draw(_graphics);
            }


            pictureBox1.Image = _mainBitmap;
        }
    }
}
