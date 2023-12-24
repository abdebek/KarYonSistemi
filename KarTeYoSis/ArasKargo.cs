using System;


namespace KarTeYoSis
{
    // ArasKargo class inheriting from DeliveryService
    public class ArasKargo : DeliveryService
    {
        public override void SendCargo(ShipmentInfo shipmentInfo)
        {
            // Implementation specific to Aras Kargo
            Console.WriteLine($"Aras Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");
        }
    }

}
