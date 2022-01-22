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

        public FlowActor(XmlService xmlService)
        {
            this.xmlService = xmlService;
        }

        internal void Execute()
        {
            var shapes = xmlService.ParseShapes();

            //IEnumerable<string> 
            var shapesResult = shapes.GroupBy(s => s.GetType().ToString());//.Select(s => s.ToString()).ToList();

            TextFileService.WriteToFile(shapesResult, ConfigurationManager.AppSettings["outputFileName"]);
        }
    }
}
