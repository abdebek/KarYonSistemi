using System.Threading.Tasks;

namespace KarYonSistemi
{
    public sealed class YurticiKargo : GonderiHizmetSaglayicisi
    {
        //Tekil örnek veya temsilci (Singleton)
        private static readonly YurticiKargo temsilci = new YurticiKargo();

        private int _tahminiBeklemeSuresi = 10000;

        private YurticiKargo() { }

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

    }

}
