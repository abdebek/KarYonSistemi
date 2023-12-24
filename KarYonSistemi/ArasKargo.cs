using System;
using System.Threading.Tasks;


namespace KarYonSistemi
{
    // ArasKargo class inheriting from DeliveryService
    public sealed class ArasKargo : DeliveryService
    {
        // Singleton instance
        private static readonly ArasKargo instance = new ArasKargo();

        // Private constructor to prevent instantiation
        private ArasKargo()
        {
        }

        // Public property to access the singleton instance
        public static ArasKargo Instance => instance;

        // Override the abstract method to implement specific behavior for Aras Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            Console.WriteLine($"Aras Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(60000); // Bir dakika sonra teslim edildi olarak güncellenmesi için

            shipmentInfo.SetDeliveryStatus(true); // Update the delivery status
            Console.WriteLine($"Product {shipmentInfo.ProductId} delivered by Aras Kargo.");
        }

    }
}
