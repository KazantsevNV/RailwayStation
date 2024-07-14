using System.Collections.Generic;

namespace RailwayStation.Model
{
    public interface IStation
    {
        public List<Point> Points { get; }
        public List<Section> Sections { get; }
        public List<Way> Ways { get; }
        public List<Park> Parks { get; }
    }
}
