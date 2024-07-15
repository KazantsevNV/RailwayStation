﻿namespace RailwayStation.Model
{
    public class Section : BaseEntity
    {
        public Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }

        public Section(int id, string description, Point firstPoint, Point secondPoint) : base(id, description)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }

        public bool ContainsPoint(Point point)
        {
            return FirstPoint.Equals(point) || SecondPoint.Equals(point);
        }
    }
}
