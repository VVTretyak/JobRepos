using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator.Models;

namespace ExamplePLCpointReader.Implementator
{
    internal interface IPoint
    {
        public IModel GetData();
    }
}
