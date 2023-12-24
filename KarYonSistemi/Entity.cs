namespace KarTeYoSis
{
    // Abstract class Entity implementing IEntity
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }

}
