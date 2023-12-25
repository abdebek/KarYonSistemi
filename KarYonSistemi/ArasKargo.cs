using System;
using System.Threading.Tasks;


namespace KarYonSistemi
{
    // ArasKargo class inheriting from DeliveryService
    public sealed class ArasKargo : DeliveryService
    {
        // Singleton instance
        private static readonly ArasKargo instance = new ArasKargo();
        private int _tahminiBeklemeSuresi = 60000;
        public override int Id { get; set; } = 0;
        public override string Name { get; set; } = "Aras Kargo";
        protected override string dahiliTelNo => "444 10 00";
        // TahminiBeklemeSuresi override edilmediği için ebeveyn sınıftaki değer kullanılacak
        public override string PhoneNumber { get; set; } = "444 25 52";
        public override string Address { get; set; } = "İstanbul";

        // Private constructor to prevent instantiation
        private ArasKargo()
        {
        }

        // Public property to access the singleton instance
        public static ArasKargo Instance => instance;

        // Override the abstract method to implement specific behavior for Aras Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            await ProcessDelivery(shipmentInfo, instance);
        }

    }
}
