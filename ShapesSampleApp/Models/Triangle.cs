using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get
            {
                return sideA;    
            }
            set 
            {
                sideA = value;
                checkGeometryTypeAssumptions();
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
                checkGeometryTypeAssumptions();
                calculateProperties();
            }
        }

        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                sideC = value;
                checkGeometryTypeAssumptions();
                calculateProperties();
            }
        }


        public Triangle(double A, double B, double C) : base()
        {
            sideA = A;
            sideB = B;
            sideC = C;
            checkGeometryTypeAssumptions();
            calculateProperties();
        }

        internal override void checkGeometryTypeAssumptions()
        {
            if  
            (
                (sideA + sideB) <= sideC ||
                (sideB + sideC) <= sideA ||
                (sideA + sideC) <= sideB
            ) 
                throw new GeometryNotPossibleException("One of the sides of triangle is longer than 2 other remaining sides.");

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new GeometryNotPossibleException("Neither of the triangle sides can be equal or less than zero.");
            }
        }

        internal override void calculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;

            Area = Math.Pow(p * (p - sideA) * (p - sideB) * (p - sideC), 0.5);
        }

        internal override void calculatePerimeter()
        {
            Perimeter = sideA + sideB + sideC;
        }

        public override string ToString()
        {
            return $"a = {sideA}, b = {sideB}, c = {sideC}, area = {Area}, perimeter = {Perimeter};";
        }
    }
}
