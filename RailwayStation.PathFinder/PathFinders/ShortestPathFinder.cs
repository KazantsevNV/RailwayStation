using RailwayStation.Model;
using System.Collections.Generic;
using System.Linq;

namespace RailwayStation.PathFinder
{
    public class ShortestPathFinder : IPathFinder
    {
        private readonly IStation station;
        private readonly List<Section> sections;
        public ShortestPathFinder() {
            station = PathFinderDIContainer.Instance.Get<IStation>();
            sections = station.Sections.ToList();
        }

        public List<Section> GetFindShortestPath(Section startSection, Section endSection) {
            var previousPoints = FindShortestPath(endSection, startSection);

            var path = new List<Section>();
            var section = startSection;

            if (!previousPoints.ContainsKey(startSection)) {
                return null;
            }

            while (section != null && previousPoints.ContainsKey(section)) {
                path.Add(section);
                section = previousPoints[section];
            }
            path.Remove(startSection);

            return path;
        }


        private Dictionary<Section, Section> FindShortestPath(Section startSection, Section endSection) {
            var previousSections = new Dictionary<Section, Section>();
            var visited = new HashSet<Section>();
            var queue = new Queue<Section>();

            queue.Enqueue(startSection);
            visited.Add(startSection);

            while (queue.Any() && !previousSections.ContainsKey(endSection)) {
                var currentSection = queue.Dequeue();

                var neighbors = currentSection.GetNeighbors(sections);

                foreach (var neighbor in neighbors) {
                    if (!visited.Contains(neighbor)) {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                        previousSections[neighbor] = currentSection;
                    }
                }
            }
            return previousSections;
        }
    }
}
