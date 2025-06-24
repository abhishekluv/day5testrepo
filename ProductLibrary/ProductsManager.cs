namespace ProductLibrary
{
    public class ProductsManager
    {
        //List<Product>
        //private global list of products
        //Generic Collection
        private List<Product> _products = new List<Product>();


        //add,remove, update, delete
        public void AddProduct(Product product)
        {
            _products.Add(product);
            Console.WriteLine("Product added successfully");
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);

            if (product != null)
            {
                _products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        public void EditProduct(int id, int units, double price)
        {
            var product = GetProductById(id);

            if(product != null)
            {
                product.UpdateProduct(units, price);
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        public void ViewProducts()
        {
            if(_products.Count > 0)
            {
                foreach(var product in _products)
                {
                    Console.WriteLine($"Product Detail: {product.Id} {product.Name} {product.Units} {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("No products available");
            }
        }

        private Product GetProductById(int id)
        {
            //LINQ: LINK
            //Language Integrated Query
            var product = _products.Where(x => x.Id == id).First();
            return product;
        }
    }
}
