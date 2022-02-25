using ShapesSampleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Services
{
    public static class TextFileService
    {
        /// <summary>
        /// Writing to file according to build-in template
        /// </summary>
        /// <param name="shapesResult"></param>
        /// <param name="name"></param>
        public static void WriteToFile(IEnumerable<IGrouping<string, Shape>> shapesResult, string name)
        {
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name)))
            {
                foreach (var group in shapesResult)
                {
                    streamWriter.WriteLine(group.Key);
                    streamWriter.WriteLine(group.Count());
                    foreach (var shape in group)
                    {
                        streamWriter.WriteLine(shape.ToString());
                    }
                }
            }
        }
    }
}
