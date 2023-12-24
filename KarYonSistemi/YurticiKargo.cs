﻿using System;
using System.Threading.Tasks;


namespace KarYonSistemi
{
    // YurticiKargo class inheriting from DeliveryService
    public sealed class YurticiKargo : DeliveryService
    {
        // Singleton instance
        private static readonly YurticiKargo instance = new YurticiKargo();
        private YurticiKargo() { }
        public static YurticiKargo Instance => instance;

        // Override the abstract method to implement specific behavior for Yurtici Kargo
        public override async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            Console.WriteLine($"Yurtici Kargo: Product {shipmentInfo.ProductId} is being delivered. Estimated time: 45 seconds.");

            // Simulate delivery time asynchronously
            await Task.Delay(30000); // Using Wait to block synchronously for the example

            shipmentInfo.SetDeliveryStatus(true); // Update the delivery status
            Console.WriteLine($"Product {shipmentInfo.ProductId} delivered by Yurtici Kargo.");
        }

    }

}
