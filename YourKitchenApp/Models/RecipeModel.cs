using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YourKitchenApp.Models;

public record Recipe(
        string Name,
        string Summary,
        Uri RecipeImage,
        DateTime Created,
        List<string> KeyWords);