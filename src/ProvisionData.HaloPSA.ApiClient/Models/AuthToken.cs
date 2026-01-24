namespace ProvisionData.HaloPSA.ApiClient.Models;

public class AuthToken
{
    [JsonPropertyName("access_token")]
    public String AccessToken { get; set; } = String.Empty;

    [JsonPropertyName("token_type")]
    public String TokenType { get; set; } = String.Empty;

    [JsonPropertyName("expires_in")]
    public Int32 ExpiresIn { get; set; }

    [JsonPropertyName("refresh_token")]
    public String RefreshToken { get; set; } = String.Empty;

    public DateTimeOffset IssuedAt { get; set; }

    public Boolean IsExpired(DateTimeOffset now)
        => IssuedAt.AddSeconds(ExpiresIn) <= now;
}
