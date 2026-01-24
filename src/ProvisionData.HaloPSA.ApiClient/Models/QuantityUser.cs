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

public class QuantityUser
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("invoice_line_id")]
    public Int32 InvoiceLineId { get; set; }

    [JsonPropertyName("kind")]
    public Int32 Kind { get; set; }

    [JsonPropertyName("type_id")]
    public Int32 TypeId { get; set; }

    [JsonPropertyName("device_group_id")]
    public Int32 DeviceGroupId { get; set; }

    [JsonPropertyName("type_name")]
    public String TypeName { get; set; } = String.Empty;
    [JsonPropertyName("device_group_name")]
    public String DeviceGroupName { get; set; } = String.Empty;
    [JsonPropertyName("site_id")]
    public Int32 SiteId { get; set; }

    [JsonPropertyName("site_name")]
    public String SiteName { get; set; } = String.Empty;
    [JsonPropertyName("licence_id")]
    public Int32 LicenceId { get; set; }

    [JsonPropertyName("licence_name")]
    public String LicenceName { get; set; } = String.Empty;
    [JsonPropertyName("assigned_licences")]
    public Boolean AssignedLicences { get; set; }

    [JsonPropertyName("qty_free")]
    public Int32 QtyFree { get; set; }

    [JsonPropertyName("minimum_qty")]
    public Int32 MinimumQty { get; set; }

    [JsonPropertyName("pro_rata")]
    public Int32 ProRata { get; set; }

    [JsonPropertyName("criteria")]
    public List<Criterion> Criteria { get; set; } = [];
    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
