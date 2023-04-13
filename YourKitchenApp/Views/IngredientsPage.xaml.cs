using YourKitchenApp.ViewModels;

namespace YourKitchenApp.Views;

public partial class IngredientsPage : ContentPage
{
	public IngredientsPage()
	{
		InitializeComponent();
		BindingContext = new IngredientPageViewModel();
	}

	
    private void CheckDatesEvent(object sender, EventArgs e)
    {
		var viewModel = (IngredientPageViewModel)BindingContext;
		viewModel.CheckExpiryDates();
    }
}