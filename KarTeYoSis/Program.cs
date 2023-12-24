using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KarTeYoSis
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            // Example usage
            ShipmentInfo shipmentInfo = new ShipmentInfo
            {
                Id = 1,
                ProductId = 101,
                SenderName = "Sender",
                ReceiverName = "Receiver"
            };

            // Choose the cargo company
            IDeliveryService deliveryService = new PTTKargo();
            deliveryService.SendCargo(shipmentInfo);

            // Check delivery status
            bool isDelivered = deliveryService.CheckDeliveryStatus(shipmentInfo.Id);
            Console.WriteLine($"Delivery Status: {isDelivered}");
        }
    }
}
