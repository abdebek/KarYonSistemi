using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    // PTTKargo class inheriting from DeliveryService
    public sealed class PTTKargo : DeliveryService
    {
        // Singleton instance
        private static readonly PTTKargo instance = new PTTKargo();
        public override int Id { get; set; } = 1;
        public override string Name { get; set; } = "PTT Kargo";
        public override string PhoneNumber { get; set; } = "444 17 88";
        public override string Address { get; set; } = "Ankara";

        private PTTKargo() { }
        public static PTTKargo Instance => instance;

        // Override the abstract method to implement specific behavior for PTT Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            Console.WriteLine($"PTT Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(5000); // 5 saniye sonra teslim edildi olarak güncellenmesi için

            shipmentInfo.SetDeliveryStatus(true); //
            Console.WriteLine($"Product {shipmentInfo.ProductId} delivered by PTT Kargo.");
        }

    }

}
