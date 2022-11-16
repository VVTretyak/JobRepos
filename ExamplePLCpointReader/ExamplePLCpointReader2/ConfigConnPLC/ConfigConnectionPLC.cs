
using ExamplePLCpointReader2.Abstraction;

namespace ExamplePLCpointReader2.ConfigConnPLC
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
