using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract class DeliveryService implementing IDeliveryService
    public abstract class DeliveryService : IDeliveryService
    {
        // Abstract method to be implemented by the derived classes
        public abstract Task SendCargo(ShipmentInfo shipmentInfo);

        //Or we can use virtual method instead of abstract method, when a default implementation is possible
        //public virtual async Task SendCargo(ShipmentInfo shipmentInfo)
        //{
        //    // To be implemented by the derived classes
        //}
    }
}
