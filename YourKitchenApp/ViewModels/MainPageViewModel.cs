using YourKitchenApp.ViewModels;
using System.Windows.Input;

namespace YourKitchenApp.ViewModels;

public class MainPageViewModel
{
    public ICommand LogoutCommand { get; }

    public MainPageViewModel ()
    {
        LogoutCommand = new Command(PerformLogoutOperation);

    }

    public async void PerformLogoutOperation(object obj)
    {
        
        await Shell.Current.GoToAsync(state: "//LoginPage");
    }
}