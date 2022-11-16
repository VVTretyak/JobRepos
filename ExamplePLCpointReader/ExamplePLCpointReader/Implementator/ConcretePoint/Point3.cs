using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator.Models;

namespace ExamplePLCpointReader.Implementator.ConcretePoint
{
    internal class Point3 : IPoint
    {
        readonly ConfigConnectionPLC _configConnPLC = null;
        public Point3(ConfigConnectionPLC configConnPLC)
        {
            _configConnPLC = configConnPLC;
        }
        public IModel GetData()
        {
            var configPoint = _configConnPLC.GetConnfig();
            var m3 = new Model3();
            System.Console.WriteLine($"Точка {m3.Id} считала данные с ПЛК");
            // Your code //
            return m3;
        }
    }
}
