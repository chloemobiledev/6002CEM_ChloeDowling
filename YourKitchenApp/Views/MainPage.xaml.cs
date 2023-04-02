using YourKitchenApp.ViewModels;

namespace YourKitchenApp;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }


    

    private async void BackToLogin(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/LoginPage");
    }

    private async void NavigateToRecipesPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/RecipesPage");
    }
    private async void ToIngredientsPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/IngredientsPage");
    }

    private async void ToRecipesPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/RecipesPage");
    }



}