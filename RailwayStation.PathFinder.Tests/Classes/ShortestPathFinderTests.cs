using Microsoft.VisualStudio.TestTools.UnitTesting;
using RailwayStation.Model;
using System.Collections.Generic;

namespace RailwayStation.PathFinder.Tests
{
    [TestClass]
    public class ShortestPathFinderTests
    {
        [TestMethod]
        public void GetFindShortestPath_returtSection2Section4Section6()
        {
            //arrange
            Point point1 = new Point(1, "Point 1");
            Point point2 = new Point(2, "Point 2");
            Point point4 = new Point(4, "Point 4");
            Point point5 = new Point(5, "Point 5");
            Point point6 = new Point(6, "Point 6");
            Point point7 = new Point(7, "Point 7");

            Section section1 = new Section(1, "Section 1", point1, point2);
            Section section2 = new Section(2, "Section 2", point2, point4);
            Section section4 = new Section(4, "Section 4", point4, point7);
            Section section5 = new Section(5, "Section 5", point5, point6);
            Section section6 = new Section(6, "Section 6", point5, point7);

            List<Section> expectedList = new List<Section>() { section2, section4, section6 };

            //act
            ShortestPathFinder finder = new ShortestPathFinder();
            List<Section> actualList = finder.GetFindShortestPath(section1, section5);

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
