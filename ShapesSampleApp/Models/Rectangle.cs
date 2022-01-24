using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public class Rectangle : Shape
    {
        private double sideA;
        private double sideB;

        public double SideA 
        {
            get
            {
                return sideA;
            }
            set
            {
                sideA = value;
                calculateProperties();
            } 
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                sideB = value;
                calculateProperties();
            }
        }

        public Rectangle(double A, double B) : base()
        {
            sideA = A;
            sideB = B;
            calculateProperties();
        }

        internal override void calculateArea()
        {
            Area = sideA * sideB;
        }

        internal override void calculatePerimeter()
        {
            Perimeter = 2 * (sideA + sideB);
        }

        public override string ToString()
        {
            return $"a = {sideA}, b = {sideB}, area = {Area}, perimeter = {Perimeter};";
        }

        internal override void checkGeometryTypeAssumptions()
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new GeometryNotPossibleException("Neither of the rectangle sides can be equal or less than zero.");
            }
        }
    }
}
