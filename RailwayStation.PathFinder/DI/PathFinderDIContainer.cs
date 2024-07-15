using Ninject;

namespace RailwayStation.PathFinder
{
    public class PathFinderDIContainer
    {
        private static readonly object LockObj = new();
        private static PathFinderDIContainer instance;
        private readonly IKernel kernel;

        private PathFinderDIContainer() {
            kernel = new StandardKernel(new PathFinderModule());
        }

        public static PathFinderDIContainer Instance {
            get {
                lock (LockObj) {
                    instance ??= new PathFinderDIContainer();
                    return instance;
                }
            }
        }

        public T Get<T>() {
            return kernel.Get<T>();
        }
    }
}
