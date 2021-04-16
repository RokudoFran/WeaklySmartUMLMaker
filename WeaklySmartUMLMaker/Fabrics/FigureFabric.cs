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

        private AbstructFigure _figure;

        public void Draw(Point start, Point finish)
        {
            if(_figure == null)
                _figure = CreateFigure();

            _figure.Draw(start, finish);
        }
        
    }
}
