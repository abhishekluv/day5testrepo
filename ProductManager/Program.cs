using ProductLibrary;

namespace ProductManager
{
    internal class Program
    {
        //global variable/fields
        private static readonly ProductsManager _productsManager = new ProductsManager();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Product Management App");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Edit Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. View Products");

                Console.WriteLine("-------------------------");

                Console.WriteLine("Enter a number to do an operation (1-4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        ViewProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }
        }

        private static void DeleteProduct()
        {
            Console.WriteLine("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            _productsManager.DeleteProduct(id);
        }

        private static void EditProduct()
        {
            Console.WriteLine("Enter Id: ");
            int id = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Units: ");
            int units = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            _productsManager.EditProduct(id, units, price);
        }

        private static void ViewProducts()
        {
            _productsManager.ViewProducts();
        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Units: ");
            int units = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(id, name, units, price);
            _productsManager.AddProduct(product);
        }
    }
}
