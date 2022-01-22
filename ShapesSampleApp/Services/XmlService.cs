using ShapesSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ShapesSampleApp.Services
{
    public class XmlService
    {
        /// <summary>
        /// Parsing shapes from execution location of the program
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Shape> ParseShapes()
        {
            var xmlDoc = XDocument.Load(ConfigurationManager.AppSettings["inputXmlDocName"]);

            var nodes = xmlDoc.Root.Elements().ToList();

            //var output = xmlDoc.Descendants.Select
            return nodes.ToShapes();
        }
    }
}
