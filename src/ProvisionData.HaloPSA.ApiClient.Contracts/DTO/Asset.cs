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

using System.Diagnostics;

namespace ProvisionData.HaloPSA.DTO;

/// <summary>
/// Partial class for Asset containing custom factory methods and business logic.
/// Custom field properties are generated in Asset.CustomFields.g.cs
/// </summary>
[DebuggerDisplay("{Id} {AssetNumber} {KeyField} {KeyField2} {KeyField3}")]
public partial class Asset
{
    /// <summary>
    /// Creates a new Asset with the specified properties.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="customerSiteId">The customer site ID.</param>
    /// <param name="assetTypeId">The asset type ID.</param>
    /// <param name="assetNumber">The asset inventory number.</param>
    /// <param name="model">The hardware model.</param>
    /// <param name="purchaseDate">The purchase date.</param>
    /// <param name="serialNumber">The serial number.</param>
    /// <param name="technicalOwnerId">The technical owner ID.</param>
    /// <param name="name">The asset name.</param>
    /// <param name="user">The assigned user.</param>
    /// <returns>A new Asset instance with all properties set.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when field mappings have not been initialized.
    /// </exception>
    public static Asset Create(
        Int32 customerId,
        Int32 customerSiteId,
        Int32 assetTypeId,
        String assetNumber,
        String model,
        DateTime purchaseDate,
        String serialNumber,
        Int32 technicalOwnerId,
        String name,
        String user)
    {
        // Ensure field mappings are initialized before creating
        if (!Mapped)
        {
            throw new InvalidOperationException(
                $"Asset field mappings not initialized. Deserialize an Asset first or call {nameof(Asset)}.{nameof(ApplyFieldMappings)}() explicitly.");
        }

        ArgumentOutOfRangeException.ThrowIfLessThan(customerId, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(customerSiteId, 1);
        ArgumentOutOfRangeException.ThrowIfLessThan(assetTypeId, 1);
        ArgumentException.ThrowIfNullOrWhiteSpace(assetNumber);
        ArgumentException.ThrowIfNullOrWhiteSpace(model);
        ArgumentException.ThrowIfNullOrWhiteSpace(serialNumber);

        var asset = new Asset
        {
            CustomerId = customerId,
            AssetTypeId = assetTypeId,
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
            KeyField = model,
            KeyField2 = purchaseDate.ToShortDateString(),
            KeyField3 = String.IsNullOrWhiteSpace(serialNumber) ? String.Empty : $"SN: {serialNumber}",
            Fields = [],
            // Use generated properties to set custom fields
            Name = name,
            User = user,
            Model = model,
            SerialNumber = serialNumber,
            PurchaseDate = purchaseDate,
        };

        return asset;
    }
}
