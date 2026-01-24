namespace ProvisionData.HaloPSA.ApiClient.Models;

public class Account
{
    [JsonPropertyName("value")]
    public required String Value { get; set; }

    [JsonPropertyName("label")]
    public required String Label { get; set; }

    [JsonPropertyName("isnew")]
    public Boolean IsNew { get; set; }

    public override String ToString() => $"{Label} ({Value})";
}

public class AssetAccount : Account;
public class ExpenseAccount : Account;
public class IncomeAccount : Account;
