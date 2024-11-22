using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class CatFood:Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}, Weight: {WeightPounds}, Kitten Food: {KittenFood}";
        }
    }
}
