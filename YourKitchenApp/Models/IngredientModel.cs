namespace YourKitchenApp.Models;

public class IngredientModel : ContentPage
{
    public record Ingredient(
        string IngName,
        string StoragePlace,
        DateTime ExpiryDate
        );
}