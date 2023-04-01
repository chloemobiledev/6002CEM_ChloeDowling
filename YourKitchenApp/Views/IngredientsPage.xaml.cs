using YourKitchenApp.ViewModels;

namespace YourKitchenApp.Views;

public partial class IngredientsPage : ContentPage
{
	public IngredientsPage()
	{
		InitializeComponent();
		BindingContext = new IngredientPageViewModel();
	}
}