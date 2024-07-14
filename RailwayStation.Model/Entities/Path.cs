using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class Path : BaseEntity
    {
        private List<Section> _sections = new List<Section>();

        public IReadOnlyList<Section> Sections => _sections;

        public Path(List<Section> sections) 
        {
            _sections = sections;
        }

        public void AddSection(Section section) 
        {
            _sections.Add(section);
        }

        public void RemoveSection(Section section) 
        {
            if (!_sections.Contains(section))
                return;

            _sections.Remove(section);
        }
    }
}
