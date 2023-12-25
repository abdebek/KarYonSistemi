using System;

namespace KarYonSistemi
{
    // Abstract class Entity implementing IEntity
    public abstract class Entity : IEntity
    {
        private int _id;
        public bool IsDeleted { get; set; } = false;
        public int Id
        {
            get { return _id; }
        }

        public Entity(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id sıfırdan küçük olamaz.");
            }

            _id = id;
        }
    }

}
