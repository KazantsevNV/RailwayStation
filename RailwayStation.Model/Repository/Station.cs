using System.Collections.Generic;
using System;

namespace RailwayStation.Model
{
    public class Station
    {
        private static readonly Lazy<Station> lazy = new Lazy<Station>(() => new Station());

        public static Station Instance => lazy.Value;

        public List<Point> Points { get; private set; }
        public List<Section> Sections { get; private set; }

        private Station()
        {
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
                point13, point14, point15, point16
            };

            var section1 = new Section(1, "Section 1", point1, point2, 10f);
            var section2 = new Section(2, "Section 2", point2, point4, 2f);
            var section3 = new Section(3, "Section 3", point3, point4, 10f);
            var section4 = new Section(4, "Section 4", point4, point7, 20f);
            var section5 = new Section(5, "Section 5", point5, point6, 10f);
            var section6 = new Section(6, "Section 6", point5, point7, 2f);
            var section7 = new Section(7, "Section 7", point7, point8, 10f);
            var section8 = new Section(8, "Section 8", point8, point14, 10f);
            var section9 = new Section(9, "Section 9", point14, point13, 10f);
            var section10 = new Section(10, "Section 10", point15, point16, 10f);
            var section11 = new Section(11, "Section 11", point9, point10, 10f);
            var section12 = new Section(12, "Section 12", point10, point12, 2f);
            var section13 = new Section(13, "Section 13", point11, point12, 10f);

            Sections = new List<Section>
            {
                section1, section2, section3, section4,
                section5, section6, section7, section8, 
                section9, section10, section11, section12, 
                section13
            };
        }
    }
}