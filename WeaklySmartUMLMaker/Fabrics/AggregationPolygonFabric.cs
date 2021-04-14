using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklySmartUMLMaker.Fabrics
{
    public class AggregationPolygonFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new AggregationPolygon(Holst.Instanse.Pen, Holst.Instanse.Graphics);
        }
    }
}
