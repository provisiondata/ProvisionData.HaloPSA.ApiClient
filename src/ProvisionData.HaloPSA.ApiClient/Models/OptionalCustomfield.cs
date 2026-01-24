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

public class OptionalCustomfield
{
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("name")]
	public String Name { get; set; } = String.Empty;
	[JsonPropertyName("label")]
	public String Label { get; set; } = String.Empty;
	[JsonPropertyName("summary")]
	public String Summary { get; set; } = String.Empty;
	[JsonPropertyName("type")]
	public Int32 Type { get; set; }

	[JsonPropertyName("value")]
	public String Value { get; set; } = String.Empty;
	[JsonPropertyName("value_is_password_id")]
	public Boolean ValueIsPasswordId { get; set; }

	[JsonPropertyName("display")]
	public String Display { get; set; } = String.Empty;
	[JsonPropertyName("characterlimit")]
	public Int32 Characterlimit { get; set; }

	[JsonPropertyName("characterlimittype")]
	public Int32 Characterlimittype { get; set; }

	[JsonPropertyName("inputtype")]
	public Int32 Inputtype { get; set; }

	[JsonPropertyName("copytochild")]
	public Boolean Copytochild { get; set; }

	[JsonPropertyName("searchable")]
	public Boolean Searchable { get; set; }

	[JsonPropertyName("ordervalues")]
	public Boolean Ordervalues { get; set; }

	[JsonPropertyName("ordervaluesby")]
	public Int32 Ordervaluesby { get; set; }

	[JsonPropertyName("database_lookup_id")]
	public Int32 DatabaseLookupId { get; set; }

	[JsonPropertyName("database_lookup_auto")]
	public Boolean DatabaseLookupAuto { get; set; }

	[JsonPropertyName("database_lookup_triggers")]
	public List<DatabaseLookupTrigger> DatabaseLookupTriggers { get; set; } = [];
	[JsonPropertyName("third_party_name")]
	public String ThirdPartyName { get; set; } = String.Empty;
	[JsonPropertyName("extratype")]
	public Int32 Extratype { get; set; }

	[JsonPropertyName("copytochildonupdate")]
	public Boolean Copytochildonupdate { get; set; }

	[JsonPropertyName("hyperlink")]
	public String Hyperlink { get; set; } = String.Empty;
	[JsonPropertyName("usage")]
	public Int32 Usage { get; set; }

	[JsonPropertyName("linked_table_id")]
	public Int32 LinkedTableId { get; set; }

	[JsonPropertyName("showondetailsscreen")]
	public Boolean Showondetailsscreen { get; set; }

	[JsonPropertyName("third_party_value")]
	public String ThirdPartyValue { get; set; } = String.Empty;
	[JsonPropertyName("custom_extra_table_id")]
	public Int32 CustomExtraTableId { get; set; }

	[JsonPropertyName("copytorelated")]
	public Boolean Copytorelated { get; set; }

	[JsonPropertyName("calculation")]
	public String Calculation { get; set; } = String.Empty;
	[JsonPropertyName("validation_reasons")]
	public List<ValidationReason> ValidationReasons { get; set; } = [];
	[JsonPropertyName("int_value_is_display")]
	public Boolean IntValueIsDisplay { get; set; }

	[JsonPropertyName("regex")]
	public String Regex { get; set; } = String.Empty;
	[JsonPropertyName("onlyshowforagents")]
	public Boolean Onlyshowforagents { get; set; }

	[JsonPropertyName("is_horizontal")]
	public Boolean IsHorizontal { get; set; }

	[JsonPropertyName("copied")]
	public Boolean Copied { get; set; }

	[JsonPropertyName("isencrypted")]
	public Boolean Isencrypted { get; set; }

	[JsonPropertyName("max_selection")]
	public Int32 MaxSelection { get; set; }

	[JsonPropertyName("selection_field_id")]
	public Int32 SelectionFieldId { get; set; }

	[JsonPropertyName("variable_format_1")]
	public String VariableFormat1 { get; set; } = String.Empty;
	[JsonPropertyName("variable_format_2")]
	public String VariableFormat2 { get; set; } = String.Empty;
	[JsonPropertyName("validation_data")]
	public List<ValidationData> ValidationData { get; set; } = [];
	[JsonPropertyName("database_lookup_input")]
	public Int32 DatabaseLookupInput { get; set; }

	[JsonPropertyName("table_data_entry_type")]
	public Int32 TableDataEntryType { get; set; }

	[JsonPropertyName("showintable")]
	public Boolean Showintable { get; set; }

	[JsonPropertyName("table_height")]
	public Int32 TableHeight { get; set; }

	[JsonPropertyName("dont_delete_rows")]
	public Boolean DontDeleteRows { get; set; }

	[JsonPropertyName("table_matching_field")]
	public Int32 TableMatchingField { get; set; }
}
