using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator.Models;

namespace ExamplePLCpointReader.Implementator.ConcretePoint
{
    internal class Point1 : IPoint
    {
        readonly ConfigConnectionPLC _configConnPLC = null;  
        public Point1(ConfigConnectionPLC configConnPLC)
        {
            _configConnPLC=configConnPLC;   
        }      
        public IModel GetData()
        {
            var configPoint = _configConnPLC.GetConnfig();
            var m1 = new Model1();
            System.Console.WriteLine($"Please wait------------------");

            System.Console.WriteLine($"Точка {m1.Id} считала данные с ПЛК");
            // Your code //
            return m1;
        }
    }
}
