using System;


namespace KarTeYoSis
{
    // PTTKargo class inheriting from DeliveryService
    public class PTTKargo : DeliveryService
    {
        public override void SendCargo(ShipmentInfo shipmentInfo)
        {
            // Implementation specific to PTT Kargo
            Console.WriteLine($"PTT Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 30 seconds.");
        }
    }

}
