using System;

namespace KarYonSistemi
{
    // ShipmentInfo class inheriting from Entity
    public class ShipmentInfo : Entity
    {
        private int _cargoId;
        public int ProductId { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }

        public ShipmentInfo(int id, int cargoId, int productId, string senderName, string receiverName) : base(id)
        {
            this.CargoId = cargoId;
            this.ProductId = productId;
            this.SenderName = senderName;
            this.ReceiverName = receiverName;
        }

        public int CargoId
        {
            get { return _cargoId; }
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("KargoId Geçersiz.");
                }
                _cargoId = (int)value;
                _cargoId = value;
            }
        }

        public bool IsDelivered { get; private set; }

        internal void SetDeliveryStatus(bool status)
        {
            this.IsDelivered = status;
        }
    }

}
