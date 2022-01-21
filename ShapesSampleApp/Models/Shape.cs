using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public abstract class Shape
    {
        public double Area { get; }

        public Shape()
        {
            calculateArea();
        }

        internal abstract double calculateArea();
    }
}
