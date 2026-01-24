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

public class UserAccess
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }
    [JsonPropertyName("criteriagroup_id")]
    public Int32 CriteriaGroupId { get; set; }
    [JsonPropertyName("service_category_id")]
    public Int32 ServiceCategoryId { get; set; }
    [JsonPropertyName("service_id")]
    public Int32 ServiceId { get; set; }
    [JsonPropertyName("type")]
    public String Type { get; set; } = String.Empty;
    [JsonPropertyName("data_id")]
    public Int32 DataId { get; set; }
    [JsonPropertyName("svrdata_guid")]
    public String SvrDataGuid { get; set; } = String.Empty;
    [JsonPropertyName("data_name")]
    public String DataName { get; set; } = String.Empty;
    [JsonPropertyName("allow_access")]
    public Boolean AllowAccess { get; set; }
    [JsonPropertyName("data_string")]
    public String DataString { get; set; } = String.Empty;
    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
