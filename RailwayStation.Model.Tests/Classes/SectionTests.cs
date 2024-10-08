using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RailwayStation.Model.Tests
{
    [TestClass]
    public class SectionTests
    {
        [TestMethod]
        public void ContainsPoint_Point1_returnTrue() {
            //arrange
            var point1 = new Point(1, "Point 1");
            var point2 = new Point(2, "Point 2");

            //act
            var section = new Section(1, "Section 1", point1, point2);
            bool actual = section.ContainsPoint(point1);

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainsPoint_Point3_returnFalse() {
            //arrange
            var point1 = new Point(1, "Point 1");
            var point2 = new Point(2, "Point 2");
            var point3 = new Point(3, "Point 3");

            //act
            var section = new Section(1, "Section 1", point1, point2);
            bool actual = section.ContainsPoint(point3);

            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetNeighbors_Section3_returnSection2AndSection4() {
            //arrange
            var point1 = new Point(1, "Point 1");
            var point2 = new Point(2, "Point 2");
            var point3 = new Point(3, "Point 3");
            var point4 = new Point(4, "Point 4");
            var point5 = new Point(5, "Point 5");

            var section1 = new Section(1, "Section 1", point1, point2);
            var section2 = new Section(2, "Section 2", point2, point3);
            var section3 = new Section(3, "Section 3", point3, point4);
            var section4 = new Section(4, "Section 4", point4, point5);

            var expectedList = new List<Section>() { section2, section4 };

            //act
            var actualList = section3.GetNeighbors(expectedList);

            //assert
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
