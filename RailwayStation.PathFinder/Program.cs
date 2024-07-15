using RailwayStation.DI;
using RailwayStation.Model;
using System;
using System.Linq;

namespace RailwayStation.PathFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pathFinder = new DijkstraPathFinder();

            var station = DIContainer.Instance.Get<IStation>();
            var points = station.Points;

            var startPoint = station.Points.First(p => p.Id == 1);
            var endPoint = station.Points.First(p => p.Id == 12);

            var shortestPath = pathFinder.GetFindShortestPath(startPoint, endPoint);

            if (shortestPath.Any())
            {
                Console.WriteLine("Shortest path from A to D:");
                foreach (var point in shortestPath)
                {
                    Console.WriteLine(point.Description);
                }
            }
            else
            {
                Console.WriteLine("No path found from A to D.");
            }
        }
    }
}
