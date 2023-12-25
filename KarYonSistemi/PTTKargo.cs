using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    // PTTKargo class inheriting from DeliveryService
    public sealed class PTTKargo : DeliveryService
    {
        // Singleton instance
        private static readonly PTTKargo instance = new PTTKargo();
        private int _tahminiBeklemeSuresi = 5000;
        public override int Id { get; set; } = 1;
        public override string Name { get; set; } = "PTT Kargo";
        protected override string dahiliTelNo => "444 10 01";
        protected override int TahminiBeklemeSuresi { get => _tahminiBeklemeSuresi; }
        public override string PhoneNumber { get; set; } = "444 17 88";
        public override string Address { get; set; } = "Ankara";

        private PTTKargo() { }
        public static PTTKargo Instance => instance;


        // Override the abstract method to implement specific behavior for PTT Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            await ProcessDelivery(shipmentInfo, instance);
        }

    }

}
