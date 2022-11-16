using ExamplePLCpointReader2.ConfigConnPLC;
using ExamplePLCpointReader2.Implementator;
using ExamplePLCpointReader2.Implementator.ConcretePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePLCpointReader2.ConcretePoint
{
    internal class InitPoints
    {
        public List<IPoint> points = null;
        public InitPoints()
        {
            Point1 point1 = new Point1(new ConfigConnectionPLC());
            Point2 point2 = new Point2(new ConfigConnectionPLC());
            Point3 point3 = new Point3(new ConfigConnectionPLC());

            points = new List<IPoint>()
            {
                point1,
                point2,
                point3, 
            };   
        }
    }
}
