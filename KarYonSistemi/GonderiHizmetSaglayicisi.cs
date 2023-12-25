using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract sınıf: IGonderiHizmetSaglayicisi, ICargo and IEntity interface'lerini uygular (kalıtım alır.).
    public abstract class GonderiHizmetSaglayicisi : IGonderiHizmetSaglayicisi, IKargo
    {
        // Abstract özellikler: kalıtım alan sınıflar tarafından override edilmek zorunda
        protected abstract string DahiliTelNo { get; }
        public abstract string TelNumarasi { get; set; }
        public abstract string Adres { get; set; }

        // Virtual özellikler: kalıtım alan sınıflar tarafından override edilebilir
        public virtual int SeriNo { get; set; }
        public virtual string Adi { get; set; }
        protected virtual int TahminiBeklemeSuresi { get; } = 60000; // 30 saniye
        public virtual bool Silinmis { get; set; }

        /// <summary>
        /// Gönderi işlemlerini başlatır.
        /// Abstract metot: kalıtım alan sınıflar tarafından override edilmek zorunda
        /// </summary>
        /// <param name="gonderi">gönderi</param>
        /// <returns></returns>
        public abstract Task KargoGonder(Gonderi gonderi);


        /// <summary>
        /// Gönderi süreçlerini yönetir.
        /// Virtual metot: kalıtım alan sınıflar tarafından override edilebilir
        /// </summary>
        /// <param name="gonderi">gönderi</param>
        /// <param name="gonderiHizmetSaglayicisi">The gonderi hizmet saglayicisi.</param>
        public virtual async Task GonderiSurecleriniYonet(Gonderi gonderi, GonderiHizmetSaglayicisi gonderiHizmetSaglayicisi)
        {
            Console.WriteLine("\n===========================================");
            Console.WriteLine($"Gönderi işlemleri başlatılıyor: {gonderi.SeriNo} numaralı gönderi için {gonderiHizmetSaglayicisi.Adi} gönderi hizmet sağlayıcısı kullanılacak.");
            Console.WriteLine($"{gonderiHizmetSaglayicisi.Adi}: Merhaba {gonderi.Alici},  {gonderi.SeriNo} numaralı bir gönderi adresinize teslim edilmek üzere teslim alınmıştır.");
            Console.WriteLine($"Tahmini bekleme süresi: {gonderiHizmetSaglayicisi.TahminiBeklemeSuresi} saniyedir.");
            Console.WriteLine("===========================================\n");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(gonderiHizmetSaglayicisi.TahminiBeklemeSuresi); // Bir dakika sonra teslim edildi olarak güncellenmesi için

            gonderi.SetDeliveryStatus(true); // Teslim edilmiş diye güncelle

            Console.WriteLine("\n===========================================");
            Console.WriteLine($"Merhaba {gonderi.Gonderici}, {gonderi.SeriNo} numaralı gönderiniz teslim edilmiştir.");
            Console.WriteLine($"Gönderi hizmetimizle alakalı memnuniyetinizi bizimle paylaşmak isterseniz: {gonderiHizmetSaglayicisi.DahiliTelNo} telefon numaramızı kullanabilirsiniz.");
            Console.WriteLine("===========================================\n");
        }
    }
}
