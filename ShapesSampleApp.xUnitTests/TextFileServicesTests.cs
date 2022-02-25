using ShapesSampleApp.Models;
using ShapesSampleApp.Services;
using ShapesSampleApp.xUnitTests.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShapesSampleApp.xUnitTests
{
    public class TextFileServicesTests
    {
        [Theory]
        [ClassData(typeof(ShapesAndExpectedOutputFilePath))]
        public void WriteToFileTest(Shape[] shapesExpected, string expectedFilePath, string actualFilePath)
        {
            //arrange
            string expected = File.ReadAllText(expectedFilePath);

            //act
            TextFileService.WriteToFile(shapesExpected.GroupBy(s => s.GetType().ToString()), actualFilePath);
            string actual = File.ReadAllText(actualFilePath);

            //asset
            Assert.Equal(actual, expected);
        }
    }
}
