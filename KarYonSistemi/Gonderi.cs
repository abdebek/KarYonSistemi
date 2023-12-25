﻿using System;

namespace KarYonSistemi
{
    public class Gonderi : Varlik
    {
        private int _cargoId;

        // Gönderi teslim edildi mi? (true/false), dışarıdan değiştirilemez.
        public bool TeslimEdildi { get; private set; }

        public int UrunNo { get; set; }
        public string Gonderici { get; set; }
        public string Alici { get; set; }

        public Gonderi(int id, int kargoNo, int urunNo, string gondericiAdi, string aliciAdi) : base(id)
        {
            this.KargoNo = kargoNo;
            this.UrunNo = urunNo;
            this.Gonderici = gondericiAdi;
            this.Alici = aliciAdi;
        }

        public int KargoNo
        {
            get { return _cargoId; }
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("KargoId Geçersiz.");
                }
                _cargoId = value;
            }
        }

        internal void SetDeliveryStatus(bool teslimEdildi)
        {
            this.TeslimEdildi = teslimEdildi;
        }
    }

}
