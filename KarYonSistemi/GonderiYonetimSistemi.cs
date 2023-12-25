using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    public class GonderiYonetimSistemi : IGonderiBilgi
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
            return urunler.FirstOrDefault(u => u.SeriNo == seriNo);
        }

        public void UrunEkle(Urun urun)
        {
            urunler.Insert(0, urun);
        }

        public Gonderi SeriNumarasiylaGonderiBul(int seriNo)
        {
            return gonderiler.FirstOrDefault(g => g.SeriNo == seriNo);
        }

        public Gonderi UrunNumarasiylaGonderiBul(int urunNo)
        {
            return gonderiler.FirstOrDefault(g => g.UrunNo == urunNo);
        }

        public void GonderiEkle(Gonderi gonderi)
        {
            gonderiler.Insert(0, gonderi);
        }

        public GonderiHizmetSaglayicisi GonderiHizmetSaglayicisiBul(int seriNo)
        {
            return gonderiHizmetSaglayicileri.FirstOrDefault(g => g.SeriNo == seriNo);
        }

        // Gönderilmemiş ürünleri getir
        public List<Urun> GonderilmemisUrunleriGetir()
        {
            List<Urun> gonderilmemisUrunler = new List<Urun>();
            foreach (var urun in urunler)
            {
                if (!gonderiler.Exists(p => p.UrunNo == urun.SeriNo))
                {
                    gonderilmemisUrunler.Add(urun);
                }
            }

            return gonderilmemisUrunler;
        }

        public async Task KargoyaVer(Gonderi gonderi)
        {
            GonderiHizmetSaglayicisi secilenGonderiHizmetSaglayicisi = GonderiHizmetSaglayicisiBul(gonderi.KargoNo);
            await secilenGonderiHizmetSaglayicisi.KargoGonder(gonderi);
        }

    }
}
