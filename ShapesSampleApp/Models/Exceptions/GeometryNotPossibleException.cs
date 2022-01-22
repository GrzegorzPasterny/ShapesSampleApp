using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp.Models
{
    internal class GeometryNotPossibleException : Exception
    {
        public readonly string message;
        public GeometryNotPossibleException(string message) : base(message)
        {
            this.message = message;
        }

        public override string Message => $"{base.Message}; InternalMessage:{message}";
    }
}
