using System.Threading.Tasks;

namespace KarYonSistemi
{
    /// <summary>
    /// sealed sınıf: GonderiHizmetSaglayicisi GonderiHizmetSaglayicisi sınıftan kalıtım alır
    /// Dolayısıyla, IGonderiHizmetSaglayicisi, ICargo and IEntity interface'lerini de uygulamış (implement etmiş) olur.
    /// </summary>
    public sealed class ArasKargo : GonderiHizmetSaglayicisi
    {
        // Tekil örnek veya temsilci
        private static readonly ArasKargo temsilci = new ArasKargo();

        // Dışarıdan ArasKargo nesnesinin türetilmesini Örneklemey önlemek için private kurucu kullanılmıştır
        private ArasKargo() { }

        // Ebeyn sınıftaki protected abstract olduğu için override edilmek zorunda
        protected override string DahiliTelNo => "444 10 00";

        // TahminiBeklemeSuresi override edilmediği için ebeveyn sınıftaki değer kullanılacak
        public override int SeriNo { get; set; } = 0;
        public override string Adi { get; set; } = "Aras Kargo";
        public override string TelNumarasi { get; set; } = "444 25 52";
        public override string Adres { get; set; } = "Adana";


        public static ArasKargo Temsilci => temsilci;

        /// <summary>
        /// Gönderi işlemlerini başlatır.
        /// Ana sınıftaki soyut metodu override eder (ezer).
        /// </summary>
        /// <param name="gonderi">gönderi</param>
        public override async Task KargoGonder(Gonderi gonderi)
        {
            await GonderiSurecleriniYonet(gonderi, temsilci);
        }

    }
}
