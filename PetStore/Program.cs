using System;
using static PetStore.Product;
using static PetStore.DogLeash;
using PetStore;
using System.Text.Json;
using static PetStore.ProductLogic;

namespace PetStore;

class Program
{
    static void Main(string[] args)
    {
        var productLogic = new ProductLogic();

        Console.WriteLine("Press 1 to add a product.");
        Console.WriteLine("Press 2 to retrieve a specific cat food.");
        Console.WriteLine("Press 3 to see the names of all in stock products.");
        Console.WriteLine("Type 'exit' to quit.");

        string userInput = Console.ReadLine();
        bool kittenFoodBool = false;

        while (userInput.ToLower() != "exit")
        {
            switch (userInput.ToLower())
            {
                case "1":
                    CatFood catFood = new CatFood();

                Console.WriteLine("What is the name?");
                var name = Console.ReadLine();

                Console.WriteLine("What is the price?");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("What is the quantity?");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the description?");
                var description = Console.ReadLine();

                Console.WriteLine("What is the weight in pounds?");
                double weightPounds = double.Parse(Console.ReadLine());

                Console.WriteLine("is this cat food??");
                var kittenFood = Console.ReadLine();
                if (kittenFood.ToLower() == "yes")
                {
                     kittenFoodBool = true;
                }
                else
                {
                    kittenFoodBool = false;
                }

                catFood.Name = name;
                catFood.Price = price;
                catFood.Quantity = quantity;
                catFood.Description= description;
                catFood.WeightPounds = weightPounds;
                catFood.KittenFood = kittenFoodBool;

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
                        Console.WriteLine(product);
                    }
                    break;

            }
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to retrieve a specific cat food.");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }

    }
}