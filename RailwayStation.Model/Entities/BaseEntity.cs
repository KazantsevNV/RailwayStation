namespace RailwayStation.Model
{
    public class BaseEntity
    {
        public int Id { get; private set; }
        public string Description { get; private set; }

        public BaseEntity(int id, string description) {
            Id = id;
            Description = description;
        }

        public override string ToString() => Description;

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            var entity = obj as BaseEntity;
            if (entity as BaseEntity == null) {
                return false;
            }

            return Equals(entity);
        }

        public bool Equals(BaseEntity entity) {
            return entity.Id == Id;
        }

        public override int GetHashCode() => Id;
    }
}
