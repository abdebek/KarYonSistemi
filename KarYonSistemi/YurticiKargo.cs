using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    public sealed class YurticiKargo : GonderiHizmetSaglayicisi
    {
        //Tekil örnek veya temsilci (Singleton)
        private static readonly YurticiKargo temsilci = new YurticiKargo();

        private int _tahminiBeklemeSuresi = 10000;

        private YurticiKargo() { }

        // Call POST: https://www.yurticikargo.com/api/kargogonder
        private async Task GonderiBilgileriniYurticiKargoSistemineGonder(Gonderi gonderi)
        {
            Console.WriteLine("Yurtici Kargo: Gönderi bilgileri Yurtici Kargo sistemine gönderiliyor...");
            Console.WriteLine("Call POST: https://www.yurticikargo.com/api/kargogonder");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(TahminiBeklemeSuresi); // Bir dakika sonra teslim edildi olarak güncellenmesi için

            gonderi.SetDeliveryStatus(true); // Teslim edilmiş diye güncelle
        }

        protected override string DahiliTelNo => "444 10 01";
        protected override int TahminiBeklemeSuresi { get => _tahminiBeklemeSuresi; }

        public override int SeriNo => 2;
        public override string Adi { get; set; } = "Yurtici Kargo";
        public override string TelNumarasi { get; set; } = "444 99 99";
        public override string Adres { get; set; } = "Kocaeli";

        public static YurticiKargo Temsilci => temsilci;

        // Override the abstract method to implement specific behavior for Yurtici Kargo
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

            await GonderiBilgileriniYurticiKargoSistemineGonder(gonderi);

            Console.WriteLine("\n===========================================");
            Console.WriteLine($"Merhaba {gonderi.Gonderici}, {SeriNo} numaralı gönderiniz teslim edilmiştir.");
            Console.WriteLine($"Gönderi hizmetimizle alakalı memnuniyetinizi bizimle paylaşmak isterseniz: {DahiliTelNo} telefon numaramızı kullanabilirsiniz.");
            Console.WriteLine("===========================================\n");
        }

    }

}
