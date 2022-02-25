using Moq;
using NLog;
using ShapesSampleApp.Models;
using ShapesSampleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ShapesSampleApp.xUnitTests.Data;
using ShapesSampleApp.xUnitTests.Comparers;

namespace ShapesSampleApp.xUnitTests
{
    public class ShapesLoading
    {
        private Mock<Logger> mockLogger = new Mock<Logger>();
        private Mock<Settings> mockSettings = new Mock<Settings>();

        [Theory]
        [ClassData(typeof(XmlPathAndExpectedShapesOutOfIt))]
        public void ParseShapes_ShouldPass(string xmlTestDataPath, Shape[] shapesExpected)
        {
            //arrange
            Settings settings = mockSettings.Object;
            settings.InputXmlDocName = xmlTestDataPath;

            XmlService xmlService = new XmlService(mockLogger.Object, settings);

            //act
            Shape[] shapesActual = xmlService.ParseShapes().ToArray();

            //assert
            Assert.Equal(shapesActual, shapesExpected, new ShapeComparer());
        }
    }
}
