using System;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    // Abstract class DeliveryService implementing IDeliveryService, ICargo and IEntity
    public abstract class DeliveryService : IDeliveryService, ICargo
    {
        // Properties
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        protected abstract string dahiliTelNo { get; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        protected virtual int TahminiBeklemeSuresi { get; } = 60000; // 30 saniye
        public virtual bool IsDeleted { get; set; }

        // Abstract method to be implemented by the derived classes
        public abstract Task SendCargo(ShipmentInfo shipmentInfo);

        //Or we can use virtual method instead of abstract method, when a default implementation is possible
        //public virtual async Task SendCargo(ShipmentInfo shipmentInfo)
        //{
        //}

        public async Task ProcessDelivery(ShipmentInfo shipmentInfo, DeliveryService deliveryService)
        {

            Console.WriteLine($"{deliveryService.Name}: Merhaba {shipmentInfo.ReceiverName},  {shipmentInfo.Id} numaralı bir gönderi adresinize teslim edilmek üzere teslim alınmıştır.");
            Console.WriteLine($"Tahmini bekleme süresi: {deliveryService.TahminiBeklemeSuresi} saniyedir.");

            // Gönderi teslim süresini simüle etmek için
            await Task.Delay(deliveryService.TahminiBeklemeSuresi); // Bir dakika sonra teslim edildi olarak güncellenmesi için

            shipmentInfo.SetDeliveryStatus(true); // Teslim edilmiş diye güncelle

            Console.WriteLine($"Merhaba {shipmentInfo.SenderName}, {shipmentInfo.Id} numaralı gönderiniz teslim edilmiştir.");
        }
    }
}
