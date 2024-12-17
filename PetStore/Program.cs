using System;
using static PetStore.Product;
using static PetStore.DogLeash;
using static PetStore.CatFood;
using PetStore;
using System.Text.Json;
using static PetStore.ProductLogic;
using static PetStore.UILogic;

namespace PetStore;

class Program
{
    static void Main(string[] args)
    {
        string userInput = String.Empty;
        var productLogic = new ProductLogic();
        var uiLogic = new UILogic(productLogic);
        while (userInput.ToLower() != "exit")
        {
            UILogic.PrintMenu();
            userInput = Console.ReadLine();
            uiLogic.MenuSelection(userInput);

            // TODO: add the logic that actually runs the program after the printing of the menu. 
            //I am currently in the middle of changing the INewProduct interface to be a generic so that I can add the DogLeash and CatFood products in the same way. 
            //I think i have done this successfully. The next step would be to add the logic for the switch statement in UILogic that would allow you to choose whether.
            //your product is a CatFood or a DogLeash.
        }

    }

    }
