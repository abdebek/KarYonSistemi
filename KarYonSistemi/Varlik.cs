using System;

namespace KarYonSistemi
{
    public abstract class Varlik : IVarlik
    {
        private int _seriNo;

        public virtual bool Silinmis { get; set; } = false;

        public int SeriNo
        {
            get { return _seriNo; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id sıfırdan küçük olamaz.");
                }
                _seriNo = value;
            }
        }

        public Varlik(int seriNO)
        {
            this.SeriNo = seriNO;
        }
    }

}
