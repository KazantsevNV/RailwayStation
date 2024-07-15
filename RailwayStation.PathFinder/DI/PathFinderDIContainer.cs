using Ninject;
using RailwayStation.Core;

namespace RailwayStation.PathFinder
{
    public class PathFinderDIContainer : AbstractDIContainer
    {
        private PathFinderDIContainer()
        {
            kernel = new StandardKernel(new PathFinderModule());
        }

        public static AbstractDIContainer Instance
        {
            get
            {
                lock (lockObj)
                {
                    instance ??= new PathFinderDIContainer();
                    return instance;
                }
            }
        }
    }
}
