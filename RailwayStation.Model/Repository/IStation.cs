using System.Collections.Generic;

namespace RailwayStation.Model
{
    public interface IStation
    {
        public IReadOnlyList<Point> Points { get; }
        public IReadOnlyList<Section> Sections { get; }
        public IReadOnlyList<Way> Ways { get; }
        public IReadOnlyList<Park> Parks { get; }
    }
}
