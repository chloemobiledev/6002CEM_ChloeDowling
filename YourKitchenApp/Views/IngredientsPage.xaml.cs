using Microsoft.VisualBasic;
using YourKitchenApp.ViewModels;
using YourKitchenApp.Models;
using Microsoft.Maui.Controls;


namespace YourKitchenApp.Views;

public partial class IngredientsPage : ContentPage
{
	public IngredientsPage()
	{
		InitializeComponent();
		BindingContext = new IngredientPageViewModel();
	}

	
}