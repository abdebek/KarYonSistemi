namespace KarYonSistemi
{
    // Product class inheriting from Entity
    public class Urun : Varlik
    {
        // para miktarı için decimal tipi tercih edilir.
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#characteristics-of-the-floating-point-types
        private decimal _fiyati;

        public string Adi { get; set; }
        public decimal Fiyati
        {
            get
            {
                return _fiyati;
            }

            set
            {

                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Price cannot be negative.");
                }

                _fiyati = value;
            }
        }

        public Urun(int id, string adi, decimal fiyati) : base(id)
        {
            this.Adi = adi;
            this.Fiyati = fiyati;
        }
    }
}
