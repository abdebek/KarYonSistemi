namespace KarYonSistemi
{
    // Product class inheriting from Entity
    public class Product : Entity
    {
        private int _price;
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

                _price = (int)value;
            }
        }

        public Product(int id, string name, decimal price) : base(id)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
