using System;

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
        public override int GetHashCode() => HashCode.Combine(Id);
        public override bool Equals(object obj) => Equals(obj as BaseEntity);
        public bool Equals(BaseEntity other) => other != null && Id == other.Id;
    }
}
