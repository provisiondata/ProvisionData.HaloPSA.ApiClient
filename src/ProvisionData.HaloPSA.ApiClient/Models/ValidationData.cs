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

namespace ProvisionData.HaloPSA.ApiClient.Models;

public class ValidationData
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }
    [JsonPropertyName("fiid")]
    public Int32 FiId { get; set; }
    [JsonPropertyName("filinktoid")]
    public Int32 FilinkToId { get; set; }
    [JsonPropertyName("validationtype")]
    public Int32 ValidationType { get; set; }
    [JsonPropertyName("askforreason")]
    public Boolean AskForReason { get; set; }
    [JsonPropertyName("hours")]
    public Int32 Hours { get; set; }
    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}

