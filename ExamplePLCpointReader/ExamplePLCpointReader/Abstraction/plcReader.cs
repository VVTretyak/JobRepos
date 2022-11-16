using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator;

namespace ExamplePLCpointReader.Abstraction
{
    internal class plcReader : AbstractPlcReader
    {
        public plcReader(IPoint implementator) : base(implementator)
        {
        }
       
        public override void Operation()
        {
            base.Operation();
        }
    }
}
