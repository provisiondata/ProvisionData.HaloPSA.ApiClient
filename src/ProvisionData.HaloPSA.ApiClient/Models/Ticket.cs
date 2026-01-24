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

public class Ticket
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("milestone_id")]
    public Int32 MilestoneId { get; set; }

    [JsonPropertyName("ticket_id")]
    public Int32 TicketId { get; set; }

    [JsonPropertyName("ticket_name")]
    public String TicketName { get; set; } = String.Empty;

    [JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
