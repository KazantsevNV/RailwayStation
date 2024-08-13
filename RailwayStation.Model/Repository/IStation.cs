using System.Collections.Generic;

namespace RailwayStation.Model
{
    public interface IStation
    {
        static readonly string NOT_FOUND_EXCEPTION_MESSAGE = "Участка с ID = {0} не существует";
        public IReadOnlyList<Point> Points { get; }
        public IReadOnlyList<Section> Sections { get; }
        public IReadOnlyList<Way> Ways { get; }
        public IReadOnlyList<Park> Parks { get; }
        public Section GetSectionById(int id);
    }
}
