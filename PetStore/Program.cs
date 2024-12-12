using System;
using static PetStore.Product;
using static PetStore.DogLeash;
using static PetStore.CatFood;
using PetStore;
using System.Text.Json;
using static PetStore.ProductLogic;

namespace PetStore;

class Program
{
    static void Main(string[] args)
    {
        string userInput = String.Empty;
        var productLogic = new ProductLogic();

        while (userInput.ToLower() != "exit")
        {
            
            Console.WriteLine("Press 1 to add a product.");
            Console.WriteLine("Press 2 to retrieve a specific cat food.");
            Console.WriteLine("Press 3 to see the names of all in stock products.");
            Console.WriteLine("Press 4 to see the total price of all products in stock.");
            Console.WriteLine("Type 'exit' to quit.");

           userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "1":
                CatFood catFood =  new CatFood();
                catFood = catFood.CreateNewCatFood();
                productLogic.AddProduct(catFood);
                Console.WriteLine("twas added muh lord");
                break;

                case "2":
                Console.WriteLine("Please enter the name of the food you would like to retrieve.");
                userInput = Console.ReadLine();
                Console.WriteLine(productLogic.GetCatFoodByName(userInput));
                break;

                case "3":
                Console.WriteLine("Here are the names of all in stock products:");
                foreach (var product in productLogic.GetOnlyInStockProducts())
                    {
                        Console.WriteLine(product.Name);
                    }
                    break;
                case "4":
                Console.WriteLine($"The total amount of all products in stock is: {productLogic.GetTotalPriceOfInventory()}");
                break;

            }

        }

    }
}