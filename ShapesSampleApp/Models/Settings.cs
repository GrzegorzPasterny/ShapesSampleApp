using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    public class Settings
    {
        public string InputXmlDocName { get; set; }
        public string OutputFileName { get; set; }

        public Settings()
        {
            InputXmlDocName = ConfigurationManager.AppSettings["inputXmlDocName"];
            OutputFileName = ConfigurationManager.AppSettings["outputFileName"];
        }
    }
}
