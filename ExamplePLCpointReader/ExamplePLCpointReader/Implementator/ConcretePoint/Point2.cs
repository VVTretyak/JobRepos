using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator.Models;

namespace ExamplePLCpointReader.Implementator.ConcretePoint
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
