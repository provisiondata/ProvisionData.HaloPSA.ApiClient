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

public partial class Asset
{
    [JsonPropertyName("infofield_101")] // Original Type: string
    public String? Infofield101 { get; set; }
    [JsonPropertyName("infofield_148")] // Original Type: string
    public String? Infofield148 { get; set; }
    [JsonPropertyName("infofield_51")] // Original Type: string
    public String? Infofield51 { get; set; }
    [JsonPropertyName("infofield_117")] // Original Type: string
    public String? Infofield117 { get; set; }
    [JsonPropertyName("infofield_24")] // Original Type: string
    public String? Infofield24 { get; set; }

    public static Asset Create(Int32 customerId, Int32 assetTypeId, Int32 customerSiteId, Int32 technicalOwnerId, String assetNumber, String name, String user, String model, String serialNumber, DateTime purchaseDate)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(customerId, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(assetTypeId, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(customerSiteId, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(technicalOwnerId, 1);
        ArgumentException.ThrowIfNullOrWhiteSpace(assetNumber);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(serialNumber);

        var asset = new Asset()
        {
            AssettypeId = assetTypeId,
            SiteId = customerSiteId,
            AssetNumber = assetNumber,
            TechnicalOwnerId = technicalOwnerId,
            BusinessOwnerId = -99,
            BusinessOwnerCabId = 1,
            TechnicalOwnerCabId = 0,
            SlaId = -1,
            PriorityId = -1,
            StatusId = 1,
            Criticality = 0,
            Inactive = false,

        };

        asset.Fields.Add(new IdValue() { Id = 101, Value = name }); // Name
        asset.Fields.Add(new IdValue() { Id = 148, Value = user }); // User
        asset.Fields.Add(new IdValue() { Id = 51, Value = model }); // Model
        asset.Fields.Add(new IdValue() { Id = 117, Value = serialNumber }); // Serial Number
        asset.Fields.Add(new IdValue() { Id = 24, Value = purchaseDate.ToString("o") }); // Purchase Date

        return asset;
    }
}
