using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract class DeliveryService implementing IDeliveryService
    public abstract class DeliveryService : IDeliveryService
    {
        public abstract Task SendCargo(ShipmentInfo shipmentInfo);
    }
}
