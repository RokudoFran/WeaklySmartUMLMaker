using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaklySmartUMLMaker.Fabrics;

namespace WeaklySmartUMLMaker
{
    public static class FigureFabricCreator
    {


        private static Dictionary<ActionType, Type> _operations = new Dictionary<ActionType, Type>()
            {
                {ActionType.Aggregation, typeof( AggregationPolygonFabric) },
                {ActionType.Association, typeof( AssociationFabric) },
                {ActionType.Composition, typeof( CompositionFabric) },
                {ActionType.CreateNewClass, typeof( CreateNewClassFabric) },
                {ActionType.Inheritance, typeof( InheritanceFabric) },
                {ActionType.Realization, typeof( RealizationFabric) },
                {ActionType.Rectangle, typeof( RectangleFabric) },
                {ActionType.Collection,typeof(CollectionFabric) },
            };

        public static FigureFabric GetFabric(ActionType type)
        {
            return (FigureFabric)Activator.CreateInstance(_operations[type]);
        }

    }
}
