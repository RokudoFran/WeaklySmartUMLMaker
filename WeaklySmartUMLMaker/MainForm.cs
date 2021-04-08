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
    public partial class MainForm : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;

        Point startPoint;
        string _act;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _tmpBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _act = "FillArrow";
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
            AbstructFigure abstructFigure = null;
            if (e.Button == MouseButtons.Left)
            {
                switch (_act)
                {
                    case "Rectangle":
                        abstructFigure = new Rectangle(pen, grafTemporary);
                        break;
                    case "FillArrow":
                        abstructFigure = new FillArrow(pen, grafTemporary);
                        break;
                    case "Inheritance":
                        abstructFigure = new InheritanceArrow(pen, grafTemporary);
                        break;
                    case "Association":
                        abstructFigure = new AssociationArrow(pen, grafTemporary);
                        break;
                    case "Realization":
                        abstructFigure = new RealizationArrow(pen, grafTemporary);
                        break;
                    case "Composition":
                        abstructFigure = new CompositionPolygon(pen, grafTemporary, blackBrush);
                        break;
                    case "Aggregation":
                        abstructFigure = new AggregationPolygon(pen, grafTemporary);
                        break;
                }
                if (abstructFigure != null)
                {
                    abstructFigure.Draw(startPoint, e.Location);
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

            switch (_act)
            {
                case "Rectangle":
                    abstructFigure = new Rectangle(pen, graf);
                    break;
                case "FillArrow":
                    abstructFigure = new FillArrow(pen, graf);
                    break;
                case "Inheritance":
                    abstructFigure = new InheritanceArrow(pen, graf);
                    break;
                case "Association":
                    abstructFigure = new AssociationArrow(pen, graf);
                    break;
                case "Realization":
                    abstructFigure = new RealizationArrow(pen, graf);
                    break;
                case "Composition":
                    abstructFigure = new CompositionPolygon(pen, graf, blackBrush);
                    break;
                case "Aggregation":
                    abstructFigure = new AggregationPolygon(pen, graf);
                    break;
            }
            if (abstructFigure != null)
            {
                abstructFigure.Draw(startPoint, e.Location);
            }
        }

        private void buttonFillArrow_Click(object sender, EventArgs e)
        {
            _act = "FillArrow";
        }

        private void buttonInheritance_Click(object sender, EventArgs e)
        {
            _act = "Inheritance";
        }

        private void buttonAssociation_Click(object sender, EventArgs e)
        {
            _act = "Association";
        }

        private void buttonRealization_Click(object sender, EventArgs e)
        {
            _act = "Realization";
        }

        private void buttonComposition_Click(object sender, EventArgs e)
        {
            _act = "Composition";
        }

        private void buttonAggregation_Click(object sender, EventArgs e)
        {
            _act = "Aggregation";
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _act = "Rectangle";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
