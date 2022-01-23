using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesSampleApp.Models;

namespace ShapesSampleAppTests
{
    [TestClass]
    public class ShapesCalculations
    {
        static IEnumerable<object[]> Shapes
        {
            get
            {
                //return new List<Shape[]>
                //{
                //    new Shape[]
                //    {
                //        //new List<Shape>()
                //        //{
                //            new Circle(12.4),
                //            new Rectangle(23,0.2),
                //            new Triangle(3,4,5)
                //        //}
                //    }
                //};
                return new[] {
                    new object[] {
                        new Circle(12.4),
                        "77.91",
                        "483.05"
                    },
                    new object[]{
                        new Rectangle(20,0.2),
                        "40.40",
                        "4.00"
                    },
                    new object[]
                    {
                        new Triangle(3,4,5),
                        "12.00",
                        "6.00"
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(Shapes))]
        public void PropertiesCalculation(Shape shape, string perimeterExpected, string areaExpected)
        {
            // arrange

            // act
            string perimeterActual = String.Format("{0:0.00}", shape.Perimeter);
            string areaActual = String.Format("{0:0.00}", shape.Area);

            // assert
            Assert.IsTrue(perimeterActual == perimeterExpected);
            Assert.IsTrue(areaActual == areaExpected);
        }
    }
}
