using System.Collections.Generic;
using System.Linq;

namespace RailwayStation.Model
{
    public class Park : BaseEntityWithList<Way>
    {
        public IReadOnlyList<Way> Ways => Entityes;

        public Park(int id, string description, List<Way> entityes) : base(id, description, entityes) {
        }

        public void AddWay(Way way) {
            AddEntity(way);
        }

        public void RemoveWay(Way way) {
            RemoveEntity(way);
        }

        public List<Point> GetAllPoints() {
            return Entityes.SelectMany(way => way.Sections)
                           .SelectMany(section => new List<Point> { section.FirstPoint, section.SecondPoint })
                           .Distinct()
                           .ToList();
        }
    }
}
