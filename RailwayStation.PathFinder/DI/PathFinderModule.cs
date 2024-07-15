using RailwayStation.Model;

namespace RailwayStation.PathFinder
{
    public class PathFinderModule : ModelModule
    {
        public override void Load() {
            base.Load();
            Bind<IPathFinder>().To<ShortestPathFinder>();
        }
    }
}
