﻿using ExamplePLCpointReader.Clients;
using System;
using System.Threading.Tasks;

namespace ExamplePLCpointReader
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Client1 client1 = new Client1();
            while (true)
            {
                client1.Run();
                await Task.Delay(3000);
            }            
        }
    }
}
