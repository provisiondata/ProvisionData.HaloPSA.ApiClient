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

public class CustomField
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
    public Int32 CharacterLimit { get; set; }

    [JsonPropertyName("characterlimittype")]
    public Int32 CharacterLimitType { get; set; }

    [JsonPropertyName("inputtype")]
    public Int32 InputType { get; set; }

    [JsonPropertyName("copytochild")]
    public Boolean CopyToChild { get; set; }

    [JsonPropertyName("copytoparent")]
    public Boolean CopyToParent { get; set; }

    [JsonPropertyName("searchable")]
    public Boolean Searchable { get; set; }

    [JsonPropertyName("ordervalues")]
    public Boolean OrderValues { get; set; }

    [JsonPropertyName("ordervaluesby")]
    public Int32 OrderValuesBy { get; set; }

    [JsonPropertyName("database_lookup_id")]
    public Int32 DatabaseLookupId { get; set; }

    [JsonPropertyName("database_lookup_auto")]
    public Boolean DatabaseLookupAuto { get; set; }

    [JsonPropertyName("database_lookup_triggers")]
    public DatabaseLookupTrigger[] DatabaseLookupTriggers { get; set; } = [];
    [JsonPropertyName("third_party_name")]
    public String ThirdPartyName { get; set; } = String.Empty;

    [JsonPropertyName("extratype")]
    public Int32 ExtraType { get; set; }

    [JsonPropertyName("copytochildonupdate")]
    public Boolean CopyToChildOnUpdate { get; set; }

    [JsonPropertyName("copytoparentonupdate")]
    public Boolean CopyToParentOnUpdate { get; set; }

    [JsonPropertyName("hyperlink")]
    public String Hyperlink { get; set; } = String.Empty;

    [JsonPropertyName("usage")]
    public Int32 Usage { get; set; }

    [JsonPropertyName("linked_table_id")]
    public Int32 LinkedTableId { get; set; }

    [JsonPropertyName("showondetailsscreen")]
    public Boolean ShowOnDetailsScreen { get; set; }

    [JsonPropertyName("third_party_value")]
    public String ThirdPartyValue { get; set; } = String.Empty;

    [JsonPropertyName("custom_extra_table_id")]
    public Int32 CustomExtraTableId { get; set; }

    [JsonPropertyName("copytorelated")]
    public Boolean CopyToRelated { get; set; }

    [JsonPropertyName("calculation")]
    public String Calculation { get; set; } = String.Empty;

    [JsonPropertyName("rounding")]
    public Int32 Rounding { get; set; }

    [JsonPropertyName("validation_reasons")]
    public ValidationReason[] ValidationReasons { get; set; } = [];
    [JsonPropertyName("int_value_is_display")]
    public Boolean IntValueIsDisplay { get; set; }

    [JsonPropertyName("regex")]
    public String Regex { get; set; } = String.Empty;

    [JsonPropertyName("onlyshowforagents")]
    public Boolean OnlyShowForAgents { get; set; }

    [JsonPropertyName("is_horizontal")]
    public Boolean IsHorizontal { get; set; }

    [JsonPropertyName("copied")]
    public Boolean Copied { get; set; }

    [JsonPropertyName("isencrypted")]
    public Boolean IsEncrypted { get; set; }

    [JsonPropertyName("max_selection")]
    public Int32 MaxSelection { get; set; }

    [JsonPropertyName("guid")]
    public String Guid { get; set; } = String.Empty;

    [JsonPropertyName("selection_field_id")]
    public Int32 SelectionFieldId { get; set; }

    [JsonPropertyName("variable_format_1")]
    public String VariableFormat1 { get; set; } = String.Empty;

    [JsonPropertyName("variable_format_2")]
    public String VariableFormat2 { get; set; } = String.Empty;

    [JsonPropertyName("validation_data")]
    public ValidationData[] ValidationData { get; set; } = [];
    [JsonPropertyName("database_lookup_input")]
    public Int32 DatabaseLookupInput { get; set; }

    [JsonPropertyName("table_data_entry_type")]
    public Int32 TableDataEntryType { get; set; }

    [JsonPropertyName("showintable")]
    public Boolean ShowInTable { get; set; }

    [JsonPropertyName("table_height")]
    public Int32 TableHeight { get; set; }

    [JsonPropertyName("dont_delete_rows")]
    public Boolean DontDeleteRows { get; set; }

    [JsonPropertyName("table_matching_field")]
    public Int32 TableMatchingField { get; set; }

    [JsonPropertyName("new_storage_method")]
    public Boolean NewStorageMethod { get; set; }

    [JsonPropertyName("where_sql")]
    public String WhereSql { get; set; } = String.Empty;

    [JsonPropertyName("load_type")]
    public Int32 LoadType { get; set; }

    [JsonPropertyName("add_rows")]
    public Boolean AddRows { get; set; }

    [JsonPropertyName("delete_these_rows")]
    public Int32[] DeleteTheseRows { get; set; } = [];
    [JsonPropertyName("showinpool")]
    public Boolean ShowInPool { get; set; }

    [JsonPropertyName("allow_pool_override")]
    public Boolean AllowPoolOverride { get; set; }

    [JsonPropertyName("details_column_group")]
    public Int32 DetailsColumnGroup { get; set; }

    [JsonPropertyName("add_row_per_value")]
    public Boolean AddRowPerValue { get; set; }

    [JsonPropertyName("store_in_fielddata")]
    public Boolean StoreInFieldData { get; set; }

    [JsonPropertyName("first_value_default")]
    public Boolean FirstValueDefault { get; set; }
}

