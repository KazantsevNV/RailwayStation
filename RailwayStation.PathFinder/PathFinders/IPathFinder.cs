using RailwayStation.Model;
using System.Collections.Generic;

namespace RailwayStation.PathFinder
{
    public interface IPathFinder
    {
        List<Section> GetFindShortestPath(Section startSection, Section endSection);
    }
}
