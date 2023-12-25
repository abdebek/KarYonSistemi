using System.Threading.Tasks;

namespace KarYonSistemi
{
    public interface IDeliveryService
    {
        Task SendCargo(ShipmentInfo shipmentInfo);
        Task ProcessDelivery(ShipmentInfo shipmentInfo, DeliveryService deliveryService);
    }
}