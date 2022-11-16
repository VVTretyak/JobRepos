using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePLCpointReader.ConfigConnPLC
{
    internal class ConfigConnectionPLC : IConfigConnPLC
    {       
        public string[] GetConnfig()
        {
            string[] configList = new string[]{"192.168.0.1","Rack0","Slot1"};          
            return configList;
        }
    }
}
