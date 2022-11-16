
using ExamplePLCpointReader2.ConcretePoint;
using ExamplePLCpointReader2.ConfigConnPLC;
//using ExamplePLCpointReader2.Implementator;
using ExamplePLCpointReader2.Implementator.ConcretePoint;
using System;
using System.Collections.Generic;

namespace ExamplePLCpointReader2.Clients
{
    internal class Client1 : IClient
    {       
        public List<IPoint> pointsList = null;
       
        public Client1()
        {
            InitPoints initPoints=new InitPoints();
            pointsList = initPoints.points;
        }

        public void Run()
        {                        
            foreach (var item in pointsList)
            {
                item.GetData();
            }                       
        }
    }
}
