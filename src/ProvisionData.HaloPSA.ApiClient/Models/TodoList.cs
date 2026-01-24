// Provision Data Systems Inc.
// Copyright (C) 2024 Doug Wilson
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

public class TodoList
{
	[JsonPropertyName("template_id")]
	public Int32 TemplateId { get; set; }

	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("text")]
    public String Text { get; set; } = String.Empty;
	[JsonPropertyName("sequence")]
	public Int32 Sequence { get; set; }

	[JsonPropertyName("allowed_clients")]
    public List<AllowedClient> AllowedClients { get; set; } = [];
	[JsonPropertyName("group_id")]
	public Int32 GroupId { get; set; }

	[JsonPropertyName("group")]
	public Group Group { get; set; } = default!;

	[JsonPropertyName("group_name")]
    public String GroupName { get; set; } = String.Empty;
	[JsonPropertyName("group_seq")]
	public Int32 GroupSeq { get; set; }

	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
	[JsonPropertyName("ticket_id")]
	public Int32 TicketId { get; set; }

	[JsonPropertyName("done")]
	public Boolean Done { get; set; }

	[JsonPropertyName("done_by_id")]
	public Int32 DoneById { get; set; }

	[JsonPropertyName("done_by_name")]
    public String DoneByName { get; set; } = String.Empty;
	[JsonPropertyName("start_date")]
	public DateTime StartDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("end_date")]
	public DateTime EndDate { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("actual_start")]
	public DateTime ActualStart { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("actual_end")]
	public DateTime ActualEnd { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("addedby")]
	public Int32 Addedby { get; set; }
}
