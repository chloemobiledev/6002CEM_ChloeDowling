namespace YourKitchenApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void NavigateToRegisterPage(System.Object sender, System.EventArgs e)

    {
        await Shell.Current.GoToAsync("/RegisterPage");
    }
}