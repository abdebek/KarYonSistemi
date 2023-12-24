namespace KarTeYoSis
{
    // ShipmentInfo class inheriting from Entity
    public class ShipmentInfo : Entity
    {
        public int ProductId { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
    }

}
