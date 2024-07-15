using Ninject;

namespace RailwayStation.Model
{
    public class ModelDIContainer 
    {
        private static readonly object LockObj = new();
        private static ModelDIContainer instance;
        private readonly IKernel kernel;

        private ModelDIContainer()
        {
            kernel = new StandardKernel(new ModelModule());
        }

        public static ModelDIContainer Instance
        {
            get
            {
                lock (LockObj)
                {
                    instance ??= new ModelDIContainer();
                    return instance;
                }
            }
        }

        public T Get<T>() {
            return kernel.Get<T>();
        }
    }
}
