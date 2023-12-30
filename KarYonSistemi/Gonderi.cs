using System;

namespace KarYonSistemi
{
    public class Gonderi : Varlik
    {
        private short _kargoNo;

        //KargoNo: Kargo hizmet sağlayıcılarının seri numaralarından biri olmalıdır.
        public short KargoNo
        {
            get { return _kargoNo; }
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("KargoNo Geçersiz.");
                }
                _kargoNo = value;
            }
        }

        public int UrunNo { get; set; }
        public string Gonderici { get; set; }
        public string Alici { get; set; }

        // Gönderi teslim edildi mi? (true/false), dışarıdan değiştirilemez.
        public bool TeslimEdildi { get; private set; }

        public Gonderi(int id, int kargoNo, int urunNo, string gondericiAdi, string aliciAdi) : base(id)
        {
            this.KargoNo = (short)kargoNo;
            this.UrunNo = urunNo;
            this.Gonderici = gondericiAdi;
            this.Alici = aliciAdi;
        }

        internal void SetDeliveryStatus(bool teslimEdildi)
        {
            this.TeslimEdildi = teslimEdildi;
        }
    }

}
