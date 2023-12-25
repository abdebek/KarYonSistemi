using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract class DeliveryService implementing IDeliveryService, ICargo and IEntity
    public abstract class DeliveryService : IDeliveryService, ICargo
    {
        // Properties
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual bool IsDeleted { get; set; }

        // Abstract method to be implemented by the derived classes
        public abstract Task SendCargo(ShipmentInfo shipmentInfo);

        //Or we can use virtual method instead of abstract method, when a default implementation is possible
        //public virtual async Task SendCargo(ShipmentInfo shipmentInfo)
        //{
        //    // To be implemented by the derived classes
        //}
    }
}
