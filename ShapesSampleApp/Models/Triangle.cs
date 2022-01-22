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
                checkTriangleAssumptions();
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
                checkTriangleAssumptions();
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
                checkTriangleAssumptions();
                calculateProperties();
            }
        }


        public Triangle(double A, double B, double C) : base()
        {
            sideA = A;
            sideB = B;
            sideC = C;
            checkTriangleAssumptions();
            calculateProperties();
        }

        private void checkTriangleAssumptions()
        {
            if  
            (
                (sideA + sideB) <= sideC ||
                (sideB + sideC) <= sideA ||
                (sideA + sideC) <= sideB
            ) 
                throw new GeometryNotPossibleException("One of the sides of triangle is longer than 2 other remaining sides.");
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
