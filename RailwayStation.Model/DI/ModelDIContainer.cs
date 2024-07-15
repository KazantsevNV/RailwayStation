using Ninject;
using RailwayStation.Core;

namespace RailwayStation.Model
{
    public class ModelDIContainer : AbstractDIContainer
    {
        private ModelDIContainer()
        {
            kernel = new StandardKernel(new ModelModule());
        }

        public static AbstractDIContainer Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new ModelDIContainer();
                    }
                    return instance;
                }
            }
        }
    }
}
