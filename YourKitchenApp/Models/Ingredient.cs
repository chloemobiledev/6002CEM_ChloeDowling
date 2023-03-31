namespace YourKitchenApp.Models;

public class Ingredient
{
	public string Name { get; set; }
	public string StoragePlace { get; set; }
	public DateTime Expiry { get; set; }

	public bool IsEmpty()
	{
		return Name == null && StoragePlace == null;
	}
}