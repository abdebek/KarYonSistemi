﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    sealed public class GonderiYonetimSistemi : IGonderiBilgi
    {
        // Singleton: Tekil nesne
        private static GonderiYonetimSistemi temsilci;

        public GonderiHizmetSaglayicisi[] gonderiHizmetSaglayicileri =
        {
            ArasKargo.Temsilci,
            PTTKargo.Temsilci,
            YurticiKargo.Temsilci
        };

        public List<Urun> urunler = new List<Urun>();
        public List<Gonderi> gonderiler = new List<Gonderi>();


        private GonderiYonetimSistemi()
        {
            OrnekVerileriYukle();
        }

        private async void OrnekVerileriYukle()
        {
            // Örnek verileri yükle
            TohumVerileri.OrnekUrunleriEkle(urunler);
            TohumVerileri.OrnekGonderileriEkle(gonderiler);
        }

        /// <summary>
        /// Bu sınıfın tekil nesnesini döndürür.
        /// Bu sınftan birden fazla nesnelerin oluşturulmasını engeller.
        /// </summary>
        /// <returns> GonderiYonetimSistemi </returns>
        public static GonderiYonetimSistemi Temsilci
        {
            get
            {
                if (temsilci == null)
                {
                    temsilci = new GonderiYonetimSistemi();
                }
                return temsilci;
            }
        }

        public Urun UrunBul(int seriNo)
        {
            return urunler.FirstOrDefault(u => !u.Silinmis && u.SeriNo == seriNo);
        }

        public void UrunEkle(Urun urun)
        {
            urunler.Insert(0, urun);
        }

        public Gonderi SeriNumarasiylaGonderiBul(int seriNo)
        {
            return gonderiler.FirstOrDefault(g => !g.Silinmis && g.SeriNo == seriNo);
        }

        public Gonderi UrunNumarasiylaGonderiBul(int urunNo)
        {
            return gonderiler.FirstOrDefault(g => !g.Silinmis && g.UrunNo == urunNo);
        }

        public void GonderiEkle(Gonderi gonderi)
        {
            gonderiler.Insert(0, gonderi);
        }

        /// <summary>
        /// Bir Gönderi hizmet saglayicisi bulmak için kullanılır.
        /// </summary>
        /// <param name="seriNo">seri no</param>
        /// <returns></returns>
        public GonderiHizmetSaglayicisi GonderiHizmetSaglayicisiBul(short seriNo)
        {
            return gonderiHizmetSaglayicileri.FirstOrDefault(g => !g.Silinmis && g.SeriNo == seriNo);
        }

        /// <summary>
        /// Mevcut (Gönderilmemiş) urunleri getir.
        /// </summary>
        /// <returns></returns>
        public List<Urun> MevcutUrunleriGetir()
        {
            List<Urun> gonderilmemisUrunler = new List<Urun>();
            foreach (var urun in urunler)
            {
                if (!gonderiler.Exists(p => p.Silinmis || p.UrunNo == urun.SeriNo))
                {
                    gonderilmemisUrunler.Add(urun);
                }
            }

            return gonderilmemisUrunler;
        }

        /// <summary>
        /// Gönderi işlemlerini başlatır.
        /// </summary>
        /// <param name="gonderi">gonderi</param>
        public async Task KargoyaVer(Gonderi gonderi)
        {
            GonderiHizmetSaglayicisi secilenGonderiHizmetSaglayicisi = GonderiHizmetSaglayicisiBul(gonderi.KargoNo);
            await secilenGonderiHizmetSaglayicisi.KargoGonder(gonderi);
        }

    }
}
