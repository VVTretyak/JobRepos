using ExamplePLCpointReader.Abstraction;
using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator;
using ExamplePLCpointReader.Implementator.ConcretePoint;
using System;
using System.Collections.Generic;

namespace ExamplePLCpointReader.Clients
{
    internal class Client1 : IClient
    {       
        public List<IPoint> pointsList = new List<IPoint>();
       
        public Client1()
        {
            pointsList.Add(new Point1(new ConfigConnectionPLC()));
            pointsList.Add(new Point2(new ConfigConnectionPLC()));
            pointsList.Add(new Point3(new ConfigConnectionPLC()));   
        }

        public void Run()
        {            
            IPoint abstractionPoint;
            AbstractPlcReader abstractPlcReader;

            foreach (var item in pointsList)
            {
                abstractionPoint = item;
                abstractPlcReader = new plcReader(abstractionPoint);
                abstractPlcReader.Operation();
            }                       
        }
    }
}
