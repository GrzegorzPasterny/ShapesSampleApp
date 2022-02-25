using ShapesSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShapesSampleApp.xUnitTests
{
    public class ShapesCalculation
    {

        [Theory]
        [InlineData(12.4, 77.91, 483.05)]
        public void PropertiesCalculation_Circle(double radius, double perimeterExpected, double areaExpected)
        {
            // arrange
            Circle circle = new Circle(radius);

            // act
            double perimeterActual = circle.Perimeter;
            double areaActual = circle.Area;

            // assert
            Assert.Equal(perimeterActual, perimeterExpected, 2);
            Assert.Equal(areaActual, areaExpected, 2);
        }

        [Theory]
        [InlineData(20, 0.2, 40.40, 4.00)]
        public void PropertiesCalculation_Rectangle(double sideA, double sideB, double perimeterExpected, double areaExpected)
        {
            // arrange
            Rectangle rectangle = new Rectangle(sideA, sideB);

            // act
            double perimeterActual = rectangle.Perimeter;
            double areaActual = rectangle.Area;

            // assert
            Assert.Equal(perimeterActual, perimeterExpected, 2);
            Assert.Equal(areaActual, areaExpected, 2);
        }

        [Theory]
        [InlineData(3,4,5,12,6)]
        public void PropertiesCalculation_Triangle(double sideA, double sideB, double sideC, double perimeterExpected, double areaExpected)
        {
            // arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // act
            double perimeterActual = triangle.Perimeter;
            double areaActual = triangle.Area;

            // assert
            Assert.Equal(perimeterActual, perimeterExpected, 2);
            Assert.Equal(areaActual, areaExpected, 2);
        }
    }
}
