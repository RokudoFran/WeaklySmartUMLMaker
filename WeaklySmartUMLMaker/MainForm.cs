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
        FillArrow,
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
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        bool _isButtonPressed = false;
        Point startPoint;
        Pen pen;
        //ArrowList arrowType;
        bool isMove = false;
        AbstructFigure _crntArrowQQQ;
        ActionType _crntArrow;
        //List<ArrowList> arrows;
        FigureFabric _fabric;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //arrows = new List<ArrowList>();
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _crntArrow = ActionType.FillArrow;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen;
            pen = new Pen(Color.Black);

            Graphics grafTemporary;
            grafTemporary = Graphics.FromImage(_tmpBitmap);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            grafTemporary.Clear(Color.White);
            AbstructFigure abstructFigure;
            if (e.Button == MouseButtons.Left)
            {
                switch (_crntArrow)
                {
                    case ActionType.Rectangle:
                        _fabric = new RectangleFabric();
                        break;
                    case ActionType.CreateNewClass:
                        _fabric = new CreateNewClassFabric();
                        break;
                    case ActionType.FillArrow:
                        _fabric = new FillArrowFabric();
                        break;
                    case ActionType.Inheritance:
                        _fabric = new InheritanceFabric();
                        break;
                    case ActionType.Association:
                        _fabric = new AssociationFabric();
                        break;
                    case ActionType.Realization:
                        _fabric = new RealizationFabric();
                        break;
                    case ActionType.Composition:
                        _fabric = new AssociationFabric();
                        break;
                    case ActionType.Aggregation:
                        _fabric = new AggregationPolygonFabric();
                        break;
                }
                if (_fabric != null)
                {
                    _fabric.Draw(startPoint, e.Location);
                }
                grafTemporary.DrawImage(_mainBitmap, 0, 0);

                pictureBox1.Image = _tmpBitmap;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen;
            pen = new Pen(Color.Black);
            Graphics graf;
            graf = Graphics.FromImage(_mainBitmap);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            AbstructFigure abstructFigure = null;

            switch (_crntArrow)
            {
                case ActionType.Rectangle:
                    _fabric = new RectangleFabric();
                    break;
                case ActionType.CreateNewClass:
                    _fabric = new CreateNewClassFabric();
                    break;
                case ActionType.FillArrow:
                    _fabric = new FillArrowFabric();
                    break;
                case ActionType.Inheritance:
                    _fabric = new InheritanceFabric();
                    break;
                case ActionType.Association:
                    _fabric = new AssociationFabric();
                    break;
                case ActionType.Realization:
                    _fabric = new RealizationFabric();
                    break;
                case ActionType.Composition:
                    _fabric = new AssociationFabric();
                    break;
                case ActionType.Aggregation:
                    _fabric = new AggregationPolygonFabric();
                    break;
            }
            if (abstructFigure != null)
            {
                abstructFigure.Draw(startPoint, e.Location);

            }
        }

        private void buttonFillArrow_Click(object sender, EventArgs e)
        {
            _crntArrow = ActionType.FillArrow;
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
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = _mainBitmap;


        }
    }
}
