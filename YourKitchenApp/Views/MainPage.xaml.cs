namespace YourKitchenApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    private async void NavigateToLoginPage(System.Object sender, System.EventArgs e)

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

    private async void ToRegisterPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/RegisterPage");
    }

    private async void ToRecipesPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/RecipesPage");
    }



}