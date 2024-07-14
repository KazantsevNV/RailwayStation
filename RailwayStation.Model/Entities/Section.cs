namespace RailwayStation.Model
{
    public class Section : BaseEntity
    {
        public Point FisrtPoint { get; private set; }
        public Point SecondPoint { get; private set; }
        public float Length { get; private set; }

        public Section(int id, string description, Point fisrtPoint, Point secondPoint, float length) : base(id, description)
        {
            FisrtPoint = fisrtPoint;
            SecondPoint = secondPoint;
            Length = length;
        }
    }
}
