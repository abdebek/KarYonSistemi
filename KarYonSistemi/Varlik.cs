using System;

namespace KarYonSistemi
{
    public abstract class Varlik : IVarlik
    {
        private int _id;

        public bool Silinmis { get; set; } = false;

        public int SeriNo
        {
            get { return _id; }
        }

        public Varlik(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id sıfırdan küçük olamaz.");
            }

            _id = id;
        }
    }

}
