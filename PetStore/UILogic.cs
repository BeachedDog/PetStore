using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public  class UILogic
    {
        private string userInput;
        private IProductLogic productLogic;

        public UILogic(IProductLogic productLogic)
        {
            this.productLogic = productLogic;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Press 1 to add a product.");
            Console.WriteLine("Press 2 to retrieve a specific product.");
            Console.WriteLine("Press 3 to see the names of all in stock products.");
            Console.WriteLine("Press 4 to see the total price of all products in stock.");
            Console.WriteLine("Type 'exit' to quit.");
        }
        public void MenuSelection(string userInput)
        {

            switch (userInput.ToLower())
            {
                case "1":
                    Console.WriteLine("Please enter the type of product you would like to add.");
                    Console.WriteLine("Options: Cat Food, Dog Leash");
                    userInput = Console.ReadLine();
                    AddProduct(userInput);
                    break;

                case "2":
                    Console.WriteLine("Please enter the name of the item you would like to retrieve.");
                    userInput = Console.ReadLine();
                    //TODO: the line below is printing the type instead of the the string representation. fix this.
                    Console.WriteLine(productLogic.GetProductByName(userInput).ToString());
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
        public void AddProduct<T>(T UserInput)
        {
            switch (UserInput.ToString().ToLower().Replace(" ", ""))
            {
                case ("catfood"):
                    CatFood catFood = new CatFood();
                    catFood = catFood.CreateNewProduct();
                    Console.WriteLine(catFood.ToString());
                    productLogic.AddProduct(catFood);
                    Console.WriteLine("twas added muh lord");
                    break;
                case ("dogleash"):
                    DogLeash dogLeash = new DogLeash();
                    dogLeash = dogLeash.CreateNewProduct();
                    productLogic.AddProduct(dogLeash);
                    Console.WriteLine("twas added muh lord");
                    break;
            }
        }
    }
}
