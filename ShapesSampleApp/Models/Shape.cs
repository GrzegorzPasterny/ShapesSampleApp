using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public abstract class Shape
    {
        public double Area { get; internal set; }
        public double Perimeter { get; internal set; }

        internal abstract void calculateArea();
        internal abstract void calculatePerimeter();
        internal abstract void checkGeometryTypeAssumptions();
        internal void calculateProperties()
        {
            checkGeometryTypeAssumptions();
            calculateArea();
            calculatePerimeter();
        }
    }
}
