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

using ProvisionData.HaloPSA.ApiClient.ModelGenerator.Models;

namespace ProvisionData.HaloPSA.ApiClient.ModelGenerator.Services;

public class ModelChangeValidator : IModelChangeValidator
{
    public Boolean IsValid(ModelChange change)
    {
        if (String.IsNullOrEmpty(change.JsonModelName))
        {
            return false;
        }

        // Model Name Change requires ClientClasslName.
        if (!String.IsNullOrEmpty(change.ClientClasslName))
        {
            // Model Name Change should have ClientClasslName and nothing else.
            return String.IsNullOrEmpty(change.JsonPropertyName)
                && String.IsNullOrEmpty(change.ClientPropertyName)
                && change.Nullable is null
                && change.Required == false;
        }

        // Property Change
        // If JsonPropertyName is provided, one or more of ClientPropertyName, Nullable, or Required must also be provided
        if (!String.IsNullOrEmpty(change.JsonPropertyName))
        {
            return !String.IsNullOrWhiteSpace(change.ClientPropertyName)
                || change.Nullable is not null
                || change.Required;
        }

        return false;
    }
}
