using System;
using System.Threading.Tasks;


namespace KarYonSistemi
{
    // YurticiKargo class inheriting from DeliveryService
    public sealed class YurticiKargo : DeliveryService
    {
        // Singleton instance
        private int _tahminiBeklemeSuresi = 10000;
        private static readonly YurticiKargo instance = new YurticiKargo();
        public override int Id { get; set; } = 2;
        public override string Name { get; set; } = "Yurtici Kargo";
        protected override string dahiliTelNo => "444 10 01";
        protected override int TahminiBeklemeSuresi { get => _tahminiBeklemeSuresi; }
        public override string PhoneNumber { get; set; } = "444 99 99";
        public override string Address { get; set; } = "İzmir";

        private YurticiKargo() { }
        public static YurticiKargo Instance => instance;

        // Override the abstract method to implement specific behavior for Yurtici Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            await ProcessDelivery(shipmentInfo, instance);
        }

    }

}
