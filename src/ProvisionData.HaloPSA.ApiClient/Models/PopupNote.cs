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

public record PopupNote
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; }

    [JsonPropertyName("date_created")]
    public DateTime DateCreated { get; set; }

    [JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;

    [JsonPropertyName("dismissable")]
    public Boolean Dismissable { get; set; }

    [JsonPropertyName("read_status")]
    public Int32 ReadStatus { get; set; }

    [JsonPropertyName("displaymodal")]
    public Boolean Displaymodal { get; set; }

    [JsonPropertyName("displayhtml")]
    public Boolean Displayhtml { get; set; }

    [JsonPropertyName("limitdaterange")]
    public Boolean Limitdaterange { get; set; }
}
