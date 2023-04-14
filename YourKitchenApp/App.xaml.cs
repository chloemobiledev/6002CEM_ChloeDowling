using YourKitchenApp.Views;


namespace YourKitchenApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        Routing.RegisterRoute("RegisterPage", typeof(RegisterPage));
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("RecipesPage", typeof(RecipesPage));
        Routing.RegisterRoute("IngredientsPage", typeof(IngredientsPage));

        MainPage = new AppShell();


    }

    public void RegisterRoutes()
    {

    }
}