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

        public override int SeriNo { get; set; } = 1;
        public override string Adi { get; set; } = "PTT Kargo";
        public override string TelNumarasi { get; set; } = "444 17 88";
        public override string Adres { get; set; } = "Sakarya";

        public static PTTKargo Temsilci => temsilci;

        public override async Task KargoGonder(Gonderi gonderi)
        {
            await GonderiSurecleriniYonet(gonderi, temsilci);
        }

    }

}
