using System;
using System.Threading.Tasks;


namespace KarYonSistemi
{
    // YurticiKargo class inheriting from DeliveryService
    public sealed class YurticiKargo : DeliveryService
    {
        // Singleton instance
        private static readonly YurticiKargo instance = new YurticiKargo();
        public override int Id { get; set; } = 2;
        public override string Name { get; set; } = "Yurtici Kargo";
        public override string PhoneNumber { get; set; } = "444 99 99";
        public override string Address { get; set; } = "İzmir";

        private YurticiKargo() { }
        public static YurticiKargo Instance => instance;

        // Override the abstract method to implement specific behavior for Yurtici Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            Console.WriteLine($"Yurtici Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(10000); // 10 saniye sonra teslim edildi olarak güncellenmesi için

            shipmentInfo.SetDeliveryStatus(true);
            Console.WriteLine($"Product {shipmentInfo.ProductId} delivered by Yurtici Kargo.");
        }

    }

}
