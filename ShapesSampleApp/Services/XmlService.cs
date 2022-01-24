using NLog;
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
        private readonly Logger logger;
        private readonly Settings settings;

        public XmlService(Logger logger, Settings settings)
        {
            this.logger = logger;
            this.settings = settings;
        }

        /// <summary>
        /// Parsing shapes from execution location of the program according to the name in app.config
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Shape> ParseShapes()
        {
            try
            {
                var xmlDoc = XDocument.Load(settings.InputXmlDocName);

                var nodes = xmlDoc.Root.Elements().ToList();

                return nodes.ToShapes();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }
    }
}
