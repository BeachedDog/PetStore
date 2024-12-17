using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class CatFood:Product, INewProduct<CatFood>
    {
        public double WeightPounds { get; set; }
        public CatFood CreateNewProduct()
        { 
            CatFood catFood = new CatFood();
            List<string> catFoodQuestions = new List<string>
            {"What is the name?", "What is the price?", "What is the quantity?", "What is the description?", "What is the weight in pounds?"};
            
            Dictionary<string, string> catFoodAnswers = new Dictionary<string, string>();
            List<string> catFoodProperties = new List<string>() { "Name", "Price", "Quantity", "Description", "WeightPounds"};
            
            for (var i=0; i<catFoodQuestions.Count; i++)
            
                {
                    Console.WriteLine(catFoodQuestions[i]);
                    catFoodAnswers.Add(catFoodProperties[i], Console.ReadLine().ToLower());
                }
            

            catFood.Name = catFoodAnswers["Name"];
            catFood.Price = decimal.Parse(catFoodAnswers["Price"]);
            catFood.Quantity = int.Parse(catFoodAnswers["Quantity"]);
            catFood.Description = catFoodAnswers["Description"];
            catFood.WeightPounds = double.Parse(catFoodAnswers["WeightPounds"]);

            Console.WriteLine(catFood.ToString());
            return catFood;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}, Weight: {WeightPounds}";
        }
    }
}
