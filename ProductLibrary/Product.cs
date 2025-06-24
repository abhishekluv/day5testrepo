namespace ProductLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Units { get; set; }
        public double Price { get; set; }

        //parameterized constructor
        public Product(int id, string name, int units, double price)
        {
            Id = id;
            Name = name;
            Units = units;
            Price = price;
        }

        public void UpdateProduct(int units, double price)
        {
            Units = units;
            Price = price;
        }
    }
}
