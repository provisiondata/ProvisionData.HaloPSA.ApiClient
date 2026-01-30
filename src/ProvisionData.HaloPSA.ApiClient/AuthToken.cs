// Provision Data HaloPSA API Client
// Copyright (C) 2026 Provision Data Systems Inc.
//
// This program is free software: you can redistribute it and/or modify it under the terms of
// the GNU Affero General Public License as published by the Free Software Foundation, either
// version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License along with this
// program. If not, see <https://www.gnu.org/licenses/>.

namespace ProvisionData.HaloPSA.ApiClient;

/// <summary>
/// Internal token model for OAuth authentication responses.
/// </summary>
internal sealed class AuthToken
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
