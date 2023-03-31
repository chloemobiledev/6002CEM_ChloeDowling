using YourKitchenApp.ViewModels;
using YourKitchenApp.Models;

namespace YourKitchenApp.Views;

public partial class RecipesPage : ContentPage
{
    public RecipesPage()
    {
        InitializeComponent();
        BindingContext = new RecipePageViewModel();
    }
}