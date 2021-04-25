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
    public interface IAction 
    {
       void Move(int deltaX, int deltaY)
        {

        }
    }

    public class MoveAction : IAction
    {

        public void Move(int deltaX, int deltaY)
        {
            
            var figure = Holst.GetHolst().CurrentFigure;
            Point tmpStart = figure.StartPoint;
            Point tmpFinish = figure.FinishPoint;
            figure.StartPoint = new Point(tmpStart.X + deltaX, tmpFinish.Y + deltaY);
            figure.FinishPoint = new Point(tmpStart.X + deltaX, tmpFinish.Y + deltaY);
        }

    }

    public class UpAction : IAction
    {

    }

    public class DownAction : IAction
    {

    }
}
