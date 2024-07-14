namespace RailwayStation.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString() => $"Id = {Id}, Description = {Description}";

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            BaseEntity entity = obj as BaseEntity;
            if (entity as BaseEntity == null)
                return false;

            return Equals(entity);
        }

        public bool Equals(BaseEntity entity) 
        {
            return entity.Id == this.Id;
        }

        public override int GetHashCode() => Id;
    }
}
