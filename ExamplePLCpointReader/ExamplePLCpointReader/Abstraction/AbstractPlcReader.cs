using ExamplePLCpointReader.ConfigConnPLC;
using ExamplePLCpointReader.Implementator;

namespace ExamplePLCpointReader.Abstraction
{
    abstract class AbstractPlcReader 
    {
        protected IPoint implementator = null;

        public AbstractPlcReader(IPoint implementator)
        {
            this.implementator = implementator;
        }

        public virtual void Operation()
        {
            implementator.GetData();
        }     
    }
}
