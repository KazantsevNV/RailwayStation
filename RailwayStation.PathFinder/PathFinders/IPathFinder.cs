using RailwayStation.Model;
using System.Collections.Generic;

namespace RailwayStation.PathFinder
{
    public interface IPathFinder
    {
        List<Point> GetFindShortestPath(Point startPoint, Point endPoint);
    }
}
