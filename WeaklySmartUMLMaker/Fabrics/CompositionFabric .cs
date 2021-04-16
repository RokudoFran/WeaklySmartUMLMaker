using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklySmartUMLMaker.Fabrics
{
    public class CompositionFabric : FigureFabric
    {
        protected override AbstructFigure CreateFigure()
        {
            return new CompositionPolygon();
        }
    }
}
