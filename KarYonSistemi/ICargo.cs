namespace KarYonSistemi
{
    // Cargo class inheriting from Entity
    public interface ICargo : IEntity
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
    }
}
