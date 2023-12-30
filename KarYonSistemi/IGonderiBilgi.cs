using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    public interface IGonderiBilgi
    {
        void GonderiEkle(Gonderi gonderi);
        void UrunEkle(Urun urun);
        Urun UrunBul(int seriNo);
        List<Urun> MevcutUrunleriGetir();
        Gonderi SeriNumarasiylaGonderiBul(int seriNo);
        GonderiHizmetSaglayicisi GonderiHizmetSaglayicisiBul(int seriNo);
        Task KargoyaVer(Gonderi gonderi);
    }
}