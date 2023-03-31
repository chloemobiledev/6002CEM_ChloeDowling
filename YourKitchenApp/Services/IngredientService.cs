using System.Security.Cryptography.X509Certificates;
using YourKitchenApp.Models;

namespace YourKitchenApp.Services;

public class IngredientService
{
	static IngredientService _instance;

	public static IngredientService Instance
	{
		get { return _instance ?? (_instance = new IngredientService()); }
	}

	public List<Ingredient> GetIngredients()
	{
        return new List<Ingredient>
        {
            new Ingredient
            {
                Name = "Beef Patty's",
                StoragePlace = "Fridge",
                Expiry = DateTime.Now
            },
            new Ingredient
            {
                Name = "Wholemeal wraps",
                StoragePlace = "Panty",
                Expiry = DateTime.Now
            },
            new Ingredient
            {
                Name = "Milk",
                StoragePlace = "Fridge",
                Expiry = DateTime.Now
            },
            new Ingredient
            {
                Name = "Onions",
                StoragePlace = "Panty",
                Expiry = DateTime.Now
            },
            new Ingredient
            {
                Name = "Chicken",
                StoragePlace = "Fridge",
                Expiry = DateTime.Now
            }
        };
	}
	
}