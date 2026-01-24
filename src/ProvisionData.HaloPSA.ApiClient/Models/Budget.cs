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

public class Budget
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("template_id")]
	public Int32 TemplateId { get; set; }

	[JsonPropertyName("hours")]
	public Int32 Hours { get; set; }

	[JsonPropertyName("days")]
	public Int32 Days { get; set; }

	[JsonPropertyName("rate")]
	public Int32 Rate { get; set; }

	[JsonPropertyName("rate_days")]
	public Int32 RateDays { get; set; }

	[JsonPropertyName("budgettype_id")]
	public Int32 BudgettypeId { get; set; }

	[JsonPropertyName("budgettype_name")]
    public String BudgettypeName { get; set; } = String.Empty;
	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
}
