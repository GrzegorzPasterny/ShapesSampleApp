using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius 
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                calculateProperties();
            } 
        }
        
        public Circle(double R) : base()
        {
            radius = R;
            calculateProperties();
        }
        
        internal override void calculateArea() 
        {
            Area = Math.PI * Math.Pow(radius, 2);
        }

        internal override void calculatePerimeter()
        {
            Perimeter = 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"r = {radius}, area = {Area}, perimeter = {Perimeter};";
        }
    }
}
