using ShapesSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShapesSampleApp.Services
{
    public static class MappingServices
    {
        public static IEnumerable<Shape> ToShapes(this IEnumerable<XElement> xElements)
        {
            foreach (var e in xElements)
            {
                yield return e.ToShape();
            }
        }

        private static Shape ToShape(this XElement xElement)
        {
            switch (xElement.Elements().Where(e => e.Name.LocalName == "type").First().Value)
            {
                case "Circle":
                    return new Circle(
                        double.Parse(
                            xElement.Elements().ElementAt(1).Value
                            ));
                case "Rectangle":
                    return new Rectangle(
                        double.Parse(
                            xElement.Elements().ElementAt(1).Value
                            ),
                        double.Parse(
                            xElement.Elements().ElementAt(2).Value
                            ));
                case "Triangle":
                    return new Triangle(
                        double.Parse(
                            xElement.Elements().ElementAt(1).Value
                            ),
                        double.Parse(
                            xElement.Elements().ElementAt(2).Value
                            ),
                        double.Parse(
                            xElement.Elements().ElementAt(3).Value
                            ));
                default:
                    throw new Exception("Invalid type was provided by input xml file.");
            }
        }
    }
}
