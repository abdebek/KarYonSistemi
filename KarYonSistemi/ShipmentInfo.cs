using System;

namespace KarYonSistemi
{
    // ShipmentInfo class inheriting from Entity
    public class ShipmentInfo : Entity
    {
        private int _cargoId;
        public int ProductId
        { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }

        public int CargoId
        {
            get { return _cargoId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("CargoId cannot be negative.");
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
