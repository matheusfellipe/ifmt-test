namespace IFMT_Testes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
          
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be zero or negative.");
            }
            Price = price;
        }
    }
}
