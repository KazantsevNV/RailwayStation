using System.Collections.Generic;

namespace RailwayStation.Model
{
    public class HardCodeStation : IStation
    {
        public IReadOnlyList<Point> Points { get; private set; }
        public IReadOnlyList<Section> Sections { get; private set; }
        public IReadOnlyList<Way> Ways { get; private set; }
        public IReadOnlyList<Park> Parks { get; private set; }

        public HardCodeStation() {
            #region points
            var point1 = new Point(1, "Point 1");
            var point2 = new Point(2, "Point 2");
            var point3 = new Point(3, "Point 3");
            var point4 = new Point(4, "Point 4");
            var point5 = new Point(5, "Point 5");
            var point6 = new Point(6, "Point 6");
            var point7 = new Point(7, "Point 7");
            var point8 = new Point(8, "Point 8");
            var point9 = new Point(9, "Point 9");
            var point10 = new Point(10, "Point 10");
            var point11 = new Point(11, "Point 11");
            var point12 = new Point(12, "Point 12");
            var point13 = new Point(13, "Point 13");
            var point14 = new Point(14, "Point 14");
            var point15 = new Point(15, "Point 15");
            var point16 = new Point(16, "Point 16");


            Points = new List<Point>
            {
                point1, point2, point3, point4,
                point5, point6, point7, point8,
                point9, point10, point11, point12,
                point13, point14, point15, point16,
            };
            #endregion
            #region sections
            var section1 = new Section(1, "Section 1", point1, point2);
            var section2 = new Section(2, "Section 2", point2, point4);
            var section3 = new Section(3, "Section 3", point3, point4);
            var section4 = new Section(4, "Section 4", point4, point7);
            var section5 = new Section(5, "Section 5", point5, point6);
            var section6 = new Section(6, "Section 6", point5, point7);
            var section7 = new Section(7, "Section 7", point7, point8);
            var section8 = new Section(8, "Section 8", point8, point14);
            var section9 = new Section(9, "Section 9", point14, point13);
            var section10 = new Section(10, "Section 10", point15, point16);
            var section11 = new Section(11, "Section 11", point9, point10);
            var section12 = new Section(12, "Section 12", point10, point12);
            var section13 = new Section(13, "Section 13", point11, point12);

            Sections = new List<Section>
            {
                section1, section2, section3, section4,
                section5, section6, section7, section8,
                section9, section10, section11, section12,
                section13,
            };
            #endregion
            #region ways
            var way1 = new Way(1, "Way 1", new List<Section> { section1, section2, });
            var way2 = new Way(2, "Way 2", new List<Section> { section3, section4, });
            var way3 = new Way(3, "Way 3", new List<Section> { section5, section6, });
            var way4 = new Way(4, "Way 4", new List<Section> { section7, section8, });
            var way5 = new Way(5, "Way 5", new List<Section> { section9, });
            var way6 = new Way(6, "Way 6", new List<Section> { section10, });
            var way7 = new Way(7, "Way 7", new List<Section> { section11, section12, section13, });

            Ways = new List<Way>
            {
                way1, way2, way3, way4,
                way5, way6, way7,
            };
            #endregion
            #region parks
            var park1 = new Park(1, "Park 1", new List<Way> { way1, way2, });
            var park2 = new Park(2, "Park 2", new List<Way> { way3, way4, });
            var park3 = new Park(3, "Park 3", new List<Way> { way5, way6, });
            var park4 = new Park(4, "Park 4", new List<Way> { way7, });

            Parks = new List<Park>
            {
                park1, park2, park3, park4,
            };
            #endregion
        }
    }
}