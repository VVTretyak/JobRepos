using ExamplePLCpointReader2.Abstraction;
using ExamplePLCpointReader2.ConfigConnPLC;

namespace ExamplePLCpointReader2
{
    internal interface IPoint
    {
        public IModel GetData();
    }
}
