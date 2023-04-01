using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourKitchenApp.Models;


    public record Ingredient(
        string IngName,
        string StoragePlace,
        DateTime ExpiryDate
        );



