using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Intents;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using YourKitchenApp.Models;
using YourKitchenApp.Views;
namespace YourKitchenApp.ViewModels;

public partial class IngredientPageViewModel : ObservableObject
{
    [ObservableProperty]
    List<Ingredient> ingredients;



    [ObservableProperty]
    bool isRefreshing;

    public IngredientPageViewModel()
    {
        LoadIngredientsAsync();
    }


    [RelayCommand]
    public async Task LoadIngredientsAsync()
    {
        try
        {
            await Task.Delay(1000);
            Ingredients = new()
            {
                new Ingredient (
                    IngName: "Eggs",
                    StoragePlace: "Cupboard",
                    ExpiryDate: DateTime.UtcNow.AddDays(10)),
                new Ingredient (
                    IngName: "Milk",
                    StoragePlace: "Fridge",
                    ExpiryDate: DateTime.UtcNow.AddDays(5)),
                new Ingredient (
                    IngName: "Red Peppers",
                    StoragePlace: "Fridge",
                    ExpiryDate: DateTime.UtcNow.AddDays(4)),
                new Ingredient (
                    IngName: "Onions",
                    StoragePlace: "Cupboard",
                    ExpiryDate: DateTime.UtcNow.AddDays(7)),
                new Ingredient (
                    IngName: "Cheese",
                    StoragePlace: "Fridge",
                    ExpiryDate: DateTime.UtcNow.AddDays(14)),
                new Ingredient (
                    IngName: "Soft Cheese",
                    StoragePlace: "Cupboard",
                    ExpiryDate: DateTime.UtcNow.AddDays(6)),
                new Ingredient (
                    IngName: "Green Beans",
                    StoragePlace: "Fridge",
                    ExpiryDate: DateTime.UtcNow.AddDays(5)),
                new Ingredient (
                    IngName: "Chicken",
                    StoragePlace: "Fridge",
                    ExpiryDate: DateTime.UtcNow.AddDays(5))
                     };

        }

        finally
        {
            IsRefreshing = false;
        }



    }
}
