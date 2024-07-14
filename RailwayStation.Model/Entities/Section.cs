namespace RailwayStation.Model
{
    public class Section : BaseEntity
    {
        public Point FisrtPoint { get; private set; }
        public Point SecondPoint { get; private set; }

        public Section(int id, string description, Point fisrtPoint, Point secondPoint) : base(id, description)
        {
            FisrtPoint = fisrtPoint;
            SecondPoint = secondPoint;
        }
    }
}
