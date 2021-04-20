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
        public abstract AbstructFigure CreateFigure();

        private AbstructFigure _figure;

        public void Draw()
        {
            if (_figure == null)
            {
                _figure = CreateFigure();
            }

            _figure.Draw();
        }
        
    }
}
