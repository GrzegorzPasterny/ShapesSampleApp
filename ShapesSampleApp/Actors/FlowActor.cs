using NLog;
using ShapesSampleApp.Models;
using ShapesSampleApp.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Actors
{
    public class FlowActor
    {
        private readonly XmlService xmlService;
        private readonly Logger logger;
        private readonly Settings settings;

        public FlowActor(XmlService xmlService, Logger logger, Settings settings)
        {
            this.xmlService = xmlService;
            this.logger = logger;
            this.settings = settings;
        }

        internal void ProcessShapesXmlToTextFile()
        {
            logger.Info("Processing data from xml file...");
            var shapes = xmlService.ParseShapes();

            var shapesResult = shapes.GroupBy(s => s.GetType().ToString());

            TextFileService.WriteToFile(shapesResult, settings.OutputFileName);
            logger.Info("Processing of the data finished.");
        }
    }
}
