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
        CreateNewClass,
        Move,
        Collection
    }


    public partial class MainForm : Form
    {
        bool _iFindYou = false;
        Point startPoint;
        ActionType _actionTipe;
        FigureFabric _fabric;
        Holst _holst;
        public List<AbstructFigure> listFigure;
        AbstructFigure _crntFigure;
        IAction _editAction = new MoveAction();
        private Point _clikPoint;
        Rectangle _rec;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listFigure = new List<AbstructFigure>(); 
            _holst =Holst.GetHolst();
            _holst.SetPictureBox(pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (Refactoring.Checked)
            //{
            //    foreach (Rectangle figure in listFigure)
            //    {
            //        if(figure is Rectangle)
            //        {
            //            if( e.Location.X > figure.StartPoint.X &&
            //               e.Location.X < figure.StartPoint.X + figure.FinishPoint.X &&
            //               e.Location.Y > figure.StartPoint.Y &&
            //               e.Location.Y < figure.StartPoint.Y + figure.FinishPoint.Y &&)
            //            {
            //               _rec =  figure;
            //            }
            //            _rec = null;
            //        }


            //        //if (FindFigure.findFigure(e.Location, figure))
            //        //{
            //        //    _holst.CurrentFigure = figure;
            //        //    _iFindYou = true;
            //        //    break;
            //        //}
            //        //_iFindYou = false;

            //    }


            //}


            if (_actionTipe == ActionType.Move)
            {
                foreach (Rectangle figure in listFigure)
                {
                    if (figure is Rectangle)
                    {
                        if (e.Location.X > figure.StartPoint.X &&
                           e.Location.X < figure.StartPoint.X + figure.FinishPoint.X &&
                           e.Location.Y > figure.StartPoint.Y &&
                           e.Location.Y < figure.StartPoint.Y + figure.FinishPoint.Y)
                        {
                            _rec = figure;
                        }
                        else
                        {
                            _rec = null;

                        }
                    }
                }
                if (_rec != null)
                {
                    //_holst.GetMainGraphics();
                    _clikPoint = e.Location;
                }

            }
            else
            {
                startPoint = e.Location;
                createFabric();
                _crntFigure = _fabric.CreateFigure();
                _crntFigure.StartPoint = e.Location;
            }


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (Refactoring.Checked)
            //{
            //    if(_editAction != null && _holst.CurrentFigure != null)
            //    {
            //        if (e.Button == MouseButtons.Left)
            //        {
            //            _holst.GetGraphics();


            //            _editAction.Move(e.Location.X, e.Location.Y);

            //            _holst.CurrentFigure.Draw();

            //            _holst.UpdatePictureBox();
            //        }
            //    }

            //}

            if (_actionTipe == ActionType.Move)
            {
                if (_rec != null)
                {
                    _holst.Clear();

                    foreach (var figure in listFigure)
                    {
                        figure.Draw();

                    }
                    _clikPoint = e.Location;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    _holst.GetGraphics();

                    if (_crntFigure != null)
                    {
                        _crntFigure.FinishPoint = e.Location;
                        _crntFigure.Draw();
                    }

                    _holst.UpdatePictureBox();
                }
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            //if (Refactoring.Checked)
            //{
               
            //}

            if (_actionTipe == ActionType.Move)
            {

            }
            else
            { 

                listFigure.Add(_crntFigure);
            }

            _holst.UpdateBitmap();
        }

        private void createFabric()
        {
            _fabric = FigureFabricCreator.GetFabric(_actionTipe);
        }


        //public static Rectangle FindRectangle(MouseEventArgs e)
        //{
        //    foreach (AbstructFigure figure in listFigure)
        //    {

        //    }
        //}


        private void buttonInheritance_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Inheritance;
            
        }

        private void buttonAssociation_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Association;
          
        }

        private void buttonRealization_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Realization;
            
        }

        private void buttonComposition_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Composition;
           
        }

        private void buttonAggregation_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Aggregation;
            
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Rectangle;
          
        }

        private void CreateNewClassButton_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.CreateNewClass;
            
        }
        private void Collection_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Collection;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _holst.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _holst.SaveBitmap();
    
            foreach (AbstructFigure a in listFigure)
            {
                a.Draw();
            }

            _holst.SavePictureBox();

        }

        private void Refactoring_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //штука, которая проверяет метод findfigure
        private void label1_Click(object sender, EventArgs e)
        {
           if(_iFindYou == true)
            {
                label1.Text = "Yes";
            }
            else
            {
                label1.Text = "No";
            }
            _iFindYou = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            _actionTipe = ActionType.Move;
            _fabric = null;
        }
    }
}
