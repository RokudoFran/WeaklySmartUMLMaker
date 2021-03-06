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
        





        public MainForm()
        {
            InitializeComponent();
            TrackBar trackBar1 = new TrackBar();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            arrows = new List<AbstructFigure>();
            _holst = Holst.GetHolst();
            _holst.SetPictureBox(pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            cretFabric();
            _crnArrow = _fabric.CreateFigure();
            _crnArrow.StartPoint = e.Location;
            _crnArrow.AbsWidth = trackBar1.Value;
            _crnArrow.AbsColor = colorDialog1.Color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _holst.GetGraphics();

                if (_crnArrow != null)
                {
                    _crnArrow.FinishPoint = e.Location;
                    _crnArrow.Draw();
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
            _holst.SaveBitmap();
            //_mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //_graphics = Graphics.FromImage(_mainBitmap);
            //_graphics.Clear(Color.White);
            foreach (AbstructFigure a in arrows)
            {
                a.Draw();
            }

            _holst.SavePictureBox();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _holst.holstPen = new Pen(colorDialog1.Color, trackBar1.Value);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            _holst.holstPen = new Pen(colorDialog1.Color, trackBar1.Value);
            _holst.holstBrush = new SolidBrush(colorDialog1.Color);
            this.BackColor = colorDialog1.Color;
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Image1";
                save.OverwritePrompt = true;
                save.CheckPathExists = true;
                save.Filter = " " +
                    "Image Files(*.JPG) | *.JPG | " +
                    "Image Files(*.PNG)| *.PNG| " +
                    "Image Files(*.SVG)| *.SVG ";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(save.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно созранить файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        



    }
}
