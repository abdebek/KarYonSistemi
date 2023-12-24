using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract class DeliveryService implementing IDeliveryService
    public abstract class DeliveryService : IDeliveryService
    {
        public virtual async Task SendCargo(ShipmentInfo shipmentInfo)
        {
            // To be implemented by the derived classes
        }
    }
}
