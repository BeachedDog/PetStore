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
        public CatFood CreateNewCatFood()
        { 
            CatFood catFood = new CatFood();
            List<string> catFoodQuestions = new List<string>
            {"What is the name?", "What is the price?", "What is the quantity?", "What is the description?", "What is the weight in pounds?", "is this cat food?" };
            
            Dictionary<string, string> catFoodAnswers = new Dictionary<string, string>();
            List<string> catFoodProperties = new List<string>() { "Name", "Price", "Quantity", "Description", "WeightPounds", "KittenFood" };
            
            for (var i=0; i<catFoodQuestions.Count; i++)
            
                {
                    Console.WriteLine(catFoodQuestions[i]);
                    catFoodAnswers.Add(catFoodProperties[i], Console.ReadLine().ToLower());
                }
            

            // TODO write the logic that will convedrt the catfoodanswers into the catfood object below

            catFood.Name = catFoodAnswers["Name"];
            catFood.Price = decimal.Parse(catFoodAnswers["Price"]);
            catFood.Quantity = int.Parse(catFoodAnswers["Quantity"]);
            catFood.Description = catFoodAnswers["Description"];
            catFood.WeightPounds = double.Parse(catFoodAnswers["WeightPounds"]);
            catFood.KittenFood = catFoodAnswers["KittenFood"]== "yes"? true :false;

            Console.WriteLine(catFood.Name);

            return catFood;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}, Weight: {WeightPounds}, Kitten Food: {KittenFood}";
        }
    }
}
