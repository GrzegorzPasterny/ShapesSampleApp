using ShapesSampleApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.xUnitTests.Data
{
    public class XmlPathAndExpectedShapesOutOfIt : IEnumerable<object[]>
    {

        private readonly List<object[]> data = new List<object[]>()
        {
            new object[]
            {
                "Files\\Shapes1.xml",
                new Shape[]
                {
                    new Circle(5.5),
                    new Rectangle(23,4.4),
                    new Triangle(4,32,30)
                }
            },
            //new object[]
            //{
            //    "path",
            //    new Circle(3),
            //    new Rectangle(2.2, 1.1),
            //    new Triangle(1,2.3,3)
            //}
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
