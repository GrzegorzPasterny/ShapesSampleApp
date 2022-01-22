using ShapesSampleApp.Services;
using System;
using System.Collections.Generic;
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
            var input = xmlService.ParseShapes();

            var list = input.ToList();

        }
    }
}
