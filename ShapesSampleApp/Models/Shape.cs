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

        public Shape()
        {
        }

        internal abstract void calculateArea();
        internal abstract void calculatePerimeter();
        internal void calculateProperties()
        {
            calculateArea();
            calculatePerimeter();
        }
    }
}
