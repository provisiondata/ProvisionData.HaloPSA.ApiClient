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

namespace ProvisionData.HaloPSA;

public class HaloApiException : Exception
{
    public HaloApiException() : base()
    {
    }

    public HaloApiException(String? message, String? json = null) : base(message)
    {
        JSON = json ?? String.Empty;
    }

    public HaloApiException(String? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    public HaloApiException(String? message, String? json, Exception? innerException)
        : base(message, innerException)
    {
        JSON = json ?? String.Empty;
    }

    public String JSON { get; } = String.Empty;
}
