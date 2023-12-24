using System;


namespace KarTeYoSis
{
    // YurticiKargo class inheriting from DeliveryService
    public class YurticiKargo : DeliveryService
    {
        public override void SendCargo(ShipmentInfo shipmentInfo)
        {
            // Implementation specific to Yurtici Kargo
            Console.WriteLine($"Yurtici Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 15 seconds.");
        }
    }

}
