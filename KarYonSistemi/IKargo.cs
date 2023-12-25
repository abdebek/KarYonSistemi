namespace KarYonSistemi
{
    // Cargo class inheriting from Entity
    public interface IKargo : IVarlik
    {
        string Adi { get; set; }
        string TelNumarasi { get; set; }
        string Adres { get; set; }
    }
}
