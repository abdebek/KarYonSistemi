using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    public sealed class PTTKargo : GonderiHizmetSaglayicisi
    {
        private static readonly PTTKargo temsilci = new PTTKargo();
        private int _tahminiBeklemeSuresi = 5000;

        private PTTKargo() { }

        protected override string DahiliTelNo => "444 10 01";
        protected override int TahminiBeklemeSuresi { get => _tahminiBeklemeSuresi; }

        public override int SeriNo { get; } = 1;
        public override string Adi { get; set; } = "PTT Kargo";
        public override string TelNumarasi { get; set; } = "444 17 88";
        public override string Adres { get; set; } = "Sakarya";

        public static PTTKargo Temsilci => temsilci;

        public override async Task KargoGonder(Gonderi gonderi)
        {
            await GonderiSurecleriniYonet(gonderi, temsilci);
        }

        public override async Task GonderiSurecleriniYonet(Gonderi gonderi, GonderiHizmetSaglayicisi gonderiHizmetSaglayicisi)
        {
            Console.WriteLine("\n===========================================");
            Console.WriteLine($"Gönderi işlemleri başlatılıyor: {SeriNo} numaralı gönderi için {Adi} gönderi hizmet sağlayıcısı kullanılacak.");
            Console.WriteLine($"{Adi}: Merhaba {gonderi.Alici},  {SeriNo} numaralı bir gönderi adresinize teslim edilmek üzere teslim alınmıştır.");
            Console.WriteLine($"Tahmini bekleme süresi: {TahminiBeklemeSuresi} saniyedir.");
            Console.WriteLine("===========================================\n");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(TahminiBeklemeSuresi); // Bir dakika sonra teslim edildi olarak güncellenmesi için

            gonderi.SetDeliveryStatus(true); // Teslim edilmiş diye güncelle

            Console.WriteLine("\n===========================================");
            Console.WriteLine($"Merhaba {gonderi.Gonderici}, {SeriNo} numaralı gönderiniz teslim edilmiştir.");
            Console.WriteLine($"Gönderi hizmetimizle alakalı memnuniyetinizi bizimle paylaşmak isterseniz: {DahiliTelNo} telefon numaramızı kullanabilirsiniz.");
            Console.WriteLine("En hızlı kargo gönderim hizmet sağlayıcısı olarak size hizmet vermekten mutluluk duyuyoruz.");
            Console.WriteLine("PTT Kargo, İyi günler diler.");
            Console.WriteLine("===========================================\n");
        }
    }

}
