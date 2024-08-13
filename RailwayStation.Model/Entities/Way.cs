using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class Way : BaseEntityWithList<Section>
    {
        public IReadOnlyList<Section> Sections => Entityes;

        public Way(int id, string description, List<Section> entityes) : base(id, description, entityes) {
        }

        public void AddSection(Section section) {
            AddEntity(section);
        }

        public void RemoveSection(Section section) {
            RemoveEntity(section);
        }
    }
}
