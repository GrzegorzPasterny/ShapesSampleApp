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
                calculateArea();
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
                calculateArea();
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
                calculateArea();
            }
        }


        public Triangle(double A, double B, double C) : base()
        {
            SideA = A;
            sideA = A;
            SideB = B;
            sideB = B;
            SideC = C;
            sideC = C;
        }

        internal override double calculateArea()
        {
            return sideA + sideB + sideC;
        }
    }
}
