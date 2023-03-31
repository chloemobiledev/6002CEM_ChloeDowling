using YourKitchenApp.Models;
using YourKitchenApp.Services;
using System.Collections.ObjectModel;
namespace YourKitchenApp.ViewModels;

public class IngredientPageViewModel : BaseViewModel
{
	ObservableCollection<Ingredient> _ingredients;

	public IngredientPageViewModel()
	{
		LoadData();
	}

	public ObservableCollection<Ingredient> Ingredients
	{
		get { return _ingredients; }
		set
		{
			_ingredients = value;
			OnPropertyChanged();
		}
	}

	private void LoadData()
	{
		Ingredients = new ObservableCollection<Ingredient>();

		Ingredients.Add(new Ingredient());

		foreach (var ingredient in IngredientService.Instance.GetIngredients())
            Ingredients.Add(ingredient);
	}
}