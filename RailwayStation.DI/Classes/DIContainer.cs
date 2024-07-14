using Ninject;

namespace RailwayStation.DI
{
    public class DIContainer
    {
        private static readonly object lockObj = new object();
        private static DIContainer instance;
        private IKernel kernel;

        private DIContainer()
        {
            kernel = new StandardKernel(new ModelModule());
        }

        public static DIContainer Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new DIContainer();
                    }
                    return instance;
                }
            }
        }

        public T Get<T>()
        {
            return kernel.Get<T>();
        }
    }
}
