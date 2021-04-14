using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklySmartUMLMaker
{
    public abstract  class FigureFabric
    {
        protected abstract AbstructFigure CreateFigure();

        public void Draw(Point start, Point finish)
        {
            AbstructFigure figure = CreateFigure();
            figure.Draw(start, finish);
        }
        
    }


    public class RectangleFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new RealizationArrow();
        }
    }

    public class CreateNewClassFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new RealizationArrow();
        }
    }


}
