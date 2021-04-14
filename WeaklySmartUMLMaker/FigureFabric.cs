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
        public void Draw(Point start, Point finish)
        {
            AbstructFigure figure = CreateFigure();
            figure.Draw(start, finish);
        }
        protected abstract AbstructFigure CreateFigure();

    }

    public class FillArrowFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new FillArrow();
        }
    }

    public class AggregationPolygonFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new AggregationPolygon(Holst.Instanse.Pen, Holst.Instanse.Graphics);
        }
    }

    public class InheritanceFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new InheritanceArrow(Holst.Instanse.Pen, Holst.Instanse.Graphics);
        }
    }
    public class RealizationFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new RealizationArrow();
        }
    }
    public class AssociationFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new RealizationArrow();
        }
    }

    public class CompositionFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new RealizationArrow();
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
