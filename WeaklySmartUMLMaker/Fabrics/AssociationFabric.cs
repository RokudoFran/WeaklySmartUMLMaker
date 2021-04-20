using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklySmartUMLMaker.Fabrics
{
    public class AssociationFabric : FigureFabric
    {
        public override AbstructFigure CreateFigure()
        {
            return new AssociationArrow();
        }
    }
}
