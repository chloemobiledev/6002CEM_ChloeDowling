using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Specialized;
using System.ComponentModel;
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
                    ExpiryDate: DateTime.UtcNow.AddHours(12)),
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

    public void CheckExpiryDates()
    {
        foreach (var ingredient in Ingredients)
        {
            var timeRemaining = ingredient.ExpiryDate - DateTime.Now;
            if (timeRemaining.TotalHours < 24)
            {
                var itemToNotify = ingredient.IngName;

                //var toast = Toast.Make(itemToNotify, CommunityToolkit.Maui.Core.ToastDuration.Long, 20);
               // toast.Show();
                //Toast.Make($"Ingredient going out of date soon: {itemToNotify}", CommunityToolkit.Maui.Core.ToastDuration.Long, 10, FontSize = 20).Show();

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                string text = $"Ingredient going out of date soon: {itemToNotify}";
                ToastDuration duration = ToastDuration.Long;
                double fontSize = 24;
                var toast = Toast.Make(text, duration, fontSize);
                toast.Show(cancellationTokenSource.Token);

               

            }
        }
    }
}
