namespace KarTeYoSis
{
    public interface IDeliveryService
    {
        bool CheckDeliveryStatus(int shipmentInfoId);
        void SendCargo(ShipmentInfo shipmentInfo);
    }
}