namespace ProvisionData.HaloPSA.ApiClient.Models;

public record Item : ItemBase;

public record CreateItem : ItemBase;

public enum AssetGroup
{
	Serialized = 20,
	Recurring = 100,
	NonSerialized = 102,
	Labour = 109,
	MiscellaneousKits = 111,
	Notebooks = 114
}
