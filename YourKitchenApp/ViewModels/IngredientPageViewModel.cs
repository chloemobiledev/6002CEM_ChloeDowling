using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Milk",
                            StoragePlace: "Fridge",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Red Peppers",
                            StoragePlace: "Fridge",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Onions",
                            StoragePlace: "Cupboard",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Cheese",
                            StoragePlace: "Fridge",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Soft Cheese",
                            StoragePlace: "Cupboard",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Green Beans",
                            StoragePlace: "Fridge",
                            ExpiryDate: DateTime.Today),
                new Ingredient (
                            IngName: "Chicken",
                            StoragePlace: "Fridge",
                           ExpiryDate: DateTime.Today)
                 };

        }

        finally
        {
            IsRefreshing = false;
        }


    }
}
