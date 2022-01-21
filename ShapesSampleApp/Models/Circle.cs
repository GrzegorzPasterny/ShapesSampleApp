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
                calculateArea();
            } 
        }
        
        public Circle(double R) : base()
        {
            radius = R;
            Radius = R;
        }
        
        internal override double calculateArea() 
        {
            return 2 * Math.PI * radius;
        }
    }
}
