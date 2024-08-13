using RailwayStation.Model;

namespace RailwayStation.PathFinder
{
    public interface IPathFinder
    {
        public string GetShortestPath(Section startSection, Section endSection);
    }
}
