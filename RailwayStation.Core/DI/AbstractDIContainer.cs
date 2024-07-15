using Ninject;

namespace RailwayStation.Core
{
    public abstract class AbstractDIContainer
    {
        protected static readonly object lockObj = new object();
        protected static AbstractDIContainer instance;
        protected IKernel kernel;

        public T Get<T>()
        {
            return kernel.Get<T>();
        }
    }
}
