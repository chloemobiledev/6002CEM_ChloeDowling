using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YourKitchenApp.Models;
using YourKitchenApp.Views;



namespace YourKitchenApp.ViewModels;

public partial class RecipePageViewModel : ObservableObject
{
    [ObservableProperty]
    List<Recipe> recipes;

    [ObservableProperty]
    bool isRefreshing;

    public RecipePageViewModel()
    {
        LoadRecipesAsync();
    }



    [RelayCommand]
    public async Task LoadRecipesAsync()
    {
        try
        {
            await Task.Delay(1000);
            Recipes = new()
                    {
                        new Recipe (
                            Name: "Veggie Lasagne",
                            Summary: "Use ready-made tomato sauce and white sauce, or batch cook the sauces and freeze them",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2022/02/vegetarian-lasagne-5ee6162.jpg?quality=90&webp=true&resize=440,400"),
                            KeyWords: new List<string> {"Veggie", "Pasta", "Tomato"}),

                        new Recipe (
                            Name: "Risotto",
                            Summary: "Italian risotto recipe, pumpkin and butternut squash, or the combination of chorizo & pea risotto.",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://th.bing.com/th/id/R.2e5e103fbefee20c89a35949d14d943f?rik=2YW5633WptjJQg&riu=http%3a%2f%2fwomanandhome.media.ipcdigital.co.uk%2f21348%2f00000cce2%2f82cc%2fChicken-risotto-recipe.jpg&ehk=BWmsC7J6VP%2bOo9enKAuBlKiVszoWdxm3iRY2g7nxqkQ%3d&risl=&pid=ImgRaw&r=0"),
                            KeyWords: new List<string> {"Rice", "Pasta", "Creamy"}),

                        new Recipe (
                            Name: "Prawn & harissa spaghetti",
                            Summary: "king prawns and harissa dressing. It only takes 20 minutes to make and is healthy too – great for a midweek meal",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2020/08/prawn-harissa-spaghetti-d29786f.jpg?quality=90&webp=true&resize=440,400"),
                            KeyWords: new List<string> {"Prawn", "Pasta", "Quick"}),
                        new Recipe (
                            Name: "Beef Chowmein",
                            Summary: "Pack in the veg with this healthy chicken fried rice, uses foods you find in the fridge for a quick and easy family supper",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2022/02/Beef-chow-mein-e16180c.jpg?quality=90&webp=true&resize=600,545"),
                            KeyWords: new List<string> {"Beef", "Noodles", "Healthy"}),
                        new Recipe (
                            Name: "Burrito bowl",
                            Summary: "This healthy burrito bowl is chock full of veggies and greens, perfect for a filling lunch",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2020/08/burrito-bowl-3629880.jpg?quality=90&webp=true&resize=440,400"),
                            KeyWords: new List<string> {"Mexican", "Spice", "Rice", "Salad"}),
                        new Recipe (
                            Name: "Pulled chicken salad",
                            Summary: "Pull apart a ready-roasted chicken to whip up this healthy, vibrant, low-calorie dish in just 20 minutes",
                            Created: DateTime.Now,
                            RecipeImage: new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2020/08/asian-pulled-chicken-salad-dbaebf8.jpg?quality=90&webp=true&resize=440,400"),
                            KeyWords: new List<string> {"Salad", "Chicken"}),

                 };

        }

        finally
        {
            IsRefreshing = false;
        }


    }
}
