using RailwayStation.Model;
using System.Collections.Generic;
using System.Linq;

namespace RailwayStation.PathFinder
{
    public class ShortestPathFinder : IPathFinder
    {
        private readonly List<Section> _sections;

        public ShortestPathFinder()
        {
            var station = PathFinderDIContainer.Instance.Get<IStation>();
            _sections = station.Sections;
        }

        public List<Point> GetFindShortestPath(Point startPoint, Point endPoint)
        {
            var previousPoints = FindShortestPath(startPoint, endPoint);

            var path = new List<Point>();
            var point = endPoint;

            if (!previousPoints.ContainsKey(endPoint))
                return path;


            while (point != null && previousPoints.ContainsKey(point))
            {
                path.Add(point);
                point = previousPoints[point];
            }
            path.Add(point);

            path.Reverse();

            return path;
        }

        private Dictionary<Point, Point> FindShortestPath(Point startPoint, Point endPoint) 
        {
            var previousPoints = new Dictionary<Point, Point>();
            var visited = new HashSet<Point>();
            var queue = new Queue<Point>();

            queue.Enqueue(startPoint);
            visited.Add(startPoint);

            while (queue.Any() && !previousPoints.ContainsKey(endPoint))
            {
                var currentPoint = queue.Dequeue();

                if (currentPoint == endPoint)
                    break;

                var neighbors = _sections.Where(section => section.ContainsPoint(currentPoint))
                                         .Select(section => section.FirstPoint.Equals(currentPoint) ? section.SecondPoint : section.FirstPoint).ToList();

                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                        previousPoints[neighbor] = currentPoint;
                    }
                }
            }
            return previousPoints;
        }
    }
}
