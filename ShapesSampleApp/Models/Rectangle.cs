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

        public Rectangle(double A, double B) : base()
        {
            SideA = A;
            sideA = A;
            SideB = B;
            sideB = B;
        }

        internal override double calculateArea()
        {
            return sideA + sideB;
        }
    }
}
