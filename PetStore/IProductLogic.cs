using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public List<Product> GetOnlyInStockProducts();

        public decimal GetTotalPriceOfInventory();

        public string GetProductByName(string name);
    }
}
