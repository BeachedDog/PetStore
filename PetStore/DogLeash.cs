using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class DogLeash : Product, INewProduct<DogLeash>
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
        public DogLeash CreateNewProduct()
        {
            DogLeash dogLeash = new DogLeash();
            List<string> dogLeashQuestions = new List<string>
            {"What is the name?", "What is the price?", "What is the quantity?", "What is the description?", "What is the length in inches?", "What material is this made from?" };

            Dictionary<string, string> dogLeashAnswers = new Dictionary<string, string>();
            List<string> dogLeashProperties = new List<string>() { "Name", "Price", "Quantity", "Description", "LengthInches", "Material" };

            for (var i = 0; i < dogLeashQuestions.Count; i++)

            {
                Console.WriteLine(dogLeashQuestions[i]);
                dogLeashAnswers.Add(dogLeashProperties[i], Console.ReadLine().ToLower());
            }


            dogLeash.Name = dogLeashAnswers["Name"];
            dogLeash.Price = decimal.Parse(dogLeashAnswers["Price"]);
            dogLeash.Quantity = int.Parse(dogLeashAnswers["Quantity"]);
            dogLeash.Description = dogLeashAnswers["Description"];
            dogLeash.LengthInches = int.Parse(dogLeashAnswers["LengthInches"]);
            dogLeash.Material = dogLeashAnswers["Material"];

            return dogLeash;
        }
 
    }
    
}
