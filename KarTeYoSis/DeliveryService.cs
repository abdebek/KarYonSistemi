namespace KarTeYoSis
{
    // Abstract class DeliveryService implementing IDeliveryService
    public abstract class DeliveryService : IDeliveryService
    {
        public virtual void SendCargo(ShipmentInfo shipmentInfo)
        {
            // Implementation specific to each cargo company
        }

        public bool CheckDeliveryStatus(int shipmentInfoId)
        {
            // Implementation to check delivery status
            // You may need to keep track of delivered shipments in a list or database
            return true; // Placeholder value, modify as needed
        }
    }

}
