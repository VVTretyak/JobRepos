using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePLCpointReader.ConfigConnPLC
{
    internal interface IConfigConnPLC
    {
        public string[] GetConnfig();
    }
}
