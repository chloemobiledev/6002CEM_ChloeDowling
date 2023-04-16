namespace YourKitchenApp.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void NavigateToLoginPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/LoginPage");
    }
    

    private async void NavigateToMainPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("////MainPage");
    }

}