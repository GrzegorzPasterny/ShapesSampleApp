using ShapesSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.xUnitTests.Comparers
{
    public class ShapeComparer : IEqualityComparer<Shape>
    {
        public bool Equals(Shape x, Shape y)
        {
            return
                x.GetType() == y.GetType() &&
                x.Area == y.Area &&
                x.Perimeter == y.Perimeter;
        }

        public int GetHashCode(Shape obj)
        {
            return
                (
                    obj.GetType().ToString() +
                    obj.Area +
                    obj.Perimeter
                ).GetHashCode();
        }
    }
}
