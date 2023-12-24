using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    // PTTKargo class inheriting from DeliveryService
    public sealed class PTTKargo : DeliveryService
    {
        // Singleton instance
        private static readonly PTTKargo instance = new PTTKargo();
        private PTTKargo() { }
        public static PTTKargo Instance => instance;

        // Override the abstract method to implement specific behavior for PTT Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            Console.WriteLine($"PTT Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");

            // Simulate delivery time asynchronously
            await Task.Delay(5000); // Using Wait to block synchronously for the example

            shipmentInfo.SetDeliveryStatus(true); // Update the delivery status
            Console.WriteLine($"Product {shipmentInfo.ProductId} delivered by PTT Kargo.");

        }

    }

}
