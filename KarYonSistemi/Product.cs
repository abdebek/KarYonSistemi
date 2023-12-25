namespace KarYonSistemi
{
    // Product class inheriting from Entity
    public class Product : Entity
    {
        // para miktarı için decimal tipi tercih edilir.
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#characteristics-of-the-floating-point-types
        private decimal _price;
        public string Name { get; set; }
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {

                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Price cannot be negative.");
                }

                _price = value;
            }
        }

        public Product(int id, string name, decimal price) : base(id)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
