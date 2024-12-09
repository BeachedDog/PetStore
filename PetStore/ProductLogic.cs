using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;

        public ProductLogic()
        {
            _products = new List<Product>
            {
                new Product {Name = "Bow", Price = 7.50m, Quantity = 0, Description = "this is an orange bow for your pet!" },
                new Product {Name = "Dog Jacket", Price = 15.50m, Quantity = 10, Description = "this is a jacket for your dog!" },
                new Product {Name = "Cat Jacket", Price = 12.50m, Quantity = 8, Description = "this is a jacket for your cat!" },
            };
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catFood.Add(product.Name, product as CatFood);
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
        public CatFood GetCatFoodByName(string name)
        {
            try
            {

                return _catFood[name];

            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _products
                .Where(x => x.Quantity > 0)
                .Select(x=>x.Name)
                .ToList();
        }
    }
}
