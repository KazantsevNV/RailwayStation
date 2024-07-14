namespace RailwayStation.Model
{
    public class Section : BaseEntity
    {
        public Point FisrtPoint { get; private set; }
        public Point SecondPoint { get; private set; }
        public float Length { get; private set; }

        public Section(Point fisrtPoint, Point secondPoint, float length)
        {
            FisrtPoint = fisrtPoint;
            SecondPoint = secondPoint;
            Length = length;
        }
    }
}
