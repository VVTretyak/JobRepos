using ExamplePLCpointReader2.Abstraction;
using ExamplePLCpointReader2.ConfigConnPLC;
using ExamplePLCpointReader2.Models;

namespace ExamplePLCpointReader2.Implementator.ConcretePoint
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
