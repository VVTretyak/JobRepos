
using ExamplePLCpointReader2.Abstraction;
using ExamplePLCpointReader2.ConfigConnPLC;
using ExamplePLCpointReader2.Models;

namespace ExamplePLCpointReader2
{
    internal class Point2 : IPoint
    {
        readonly ConfigConnectionPLC _configConnPLC = null;
        public Point2(ConfigConnectionPLC configConnPLC)
        {
            _configConnPLC = configConnPLC;
        }
        public IModel GetData()
        {
            var configPoint = _configConnPLC.GetConnfig();
            var m2 = new Model2();
            System.Console.WriteLine($"Точка {m2.Id} считала данные с ПЛК");
            // Your code //
            return m2;
        }
    }
}
