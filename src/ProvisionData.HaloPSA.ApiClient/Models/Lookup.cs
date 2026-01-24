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



public partial class Lookup

{
	[JsonPropertyName("access_control")]

	public List<AccessControl>? AccessControl { get; set; }

	[JsonPropertyName("access_control_level")]
	public Int32? AccessControlLevel { get; set; }
	[JsonPropertyName("column_profile_name")]

	public String? ColumnProfileName { get; set; }

	[JsonPropertyName("contract_ref")]

	public String? ContractRef { get; set; }

	[JsonPropertyName("custom1")]

	public String? Custom1 { get; set; }

	[JsonPropertyName("custom1_bool")]
	public Boolean? Custom1Bool { get; set; }
	[JsonPropertyName("custom2")]

	public String? Custom2 { get; set; }

	[JsonPropertyName("dynamics_company_name")]

	public String? DynamicsCompanyName { get; set; }

	[JsonPropertyName("email_template_name")]

	public String? EmailTemplateName { get; set; }

	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("_importtype")]

	public String? Importtype { get; set; }

	[JsonPropertyName("inactive")]
	public Boolean? Inactive { get; set; }
	[JsonPropertyName("intent")]

	public String? Intent { get; set; }

	[JsonPropertyName("_isimport")]
	public Boolean? Isimport { get; set; }
	[JsonPropertyName("_isnewcode")]
	public Boolean? Isnewcode { get; set; }
	[JsonPropertyName("jira_instance_name")]

	public String? JiraInstanceName { get; set; }

	[JsonPropertyName("kashflow_tenant")]

	public String? KashflowTenant { get; set; }

	[JsonPropertyName("linked_item")]

	public String? LinkedItem { get; set; }

	[JsonPropertyName("lookupid")]
	public Int32? Lookupid { get; set; }
	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("originalvalue")]

	public String? Originalvalue { get; set; }

	[JsonPropertyName("overriding_rate_id")]
	public Int32? OverridingRateId { get; set; }

	//[JsonPropertyName("rates")]
	//public List<UntypedNode>? Rates { get; set; }

	[JsonPropertyName("sequence")]
	public Int32? Sequence { get; set; }
	[JsonPropertyName("sla_name")]

	public String? SlaName { get; set; }

	[JsonPropertyName("sub_lookup")]

	public List<Lookup>? SubLookup { get; set; }

	[JsonPropertyName("surcharge_item_name")]

	public String? SurchargeItemName { get; set; }

	[JsonPropertyName("tax_rate_name")]

	public String? TaxRateName { get; set; }

	//[JsonPropertyName("translations")]
	//public List<UntypedNode>? Translations { get; set; }

	[JsonPropertyName("value10")]

	public String? Value10 { get; set; }

	[JsonPropertyName("value10_bool")]
	public Boolean? Value10Bool { get; set; }
	[JsonPropertyName("value2")]

	public String? Value2 { get; set; }

	[JsonPropertyName("value2_bool")]
	public Boolean? Value2Bool { get; set; }
	[JsonPropertyName("value2_guid")]
	public Guid? Value2Guid { get; set; }
	[JsonPropertyName("value3")]

	public String? Value3 { get; set; }

	[JsonPropertyName("value3_bool")]
	public Boolean? Value3Bool { get; set; }
	[JsonPropertyName("value4")]

	public String? Value4 { get; set; }

	[JsonPropertyName("value4_bool")]
	public Boolean? Value4Bool { get; set; }
	[JsonPropertyName("value5")]

	public String? Value5 { get; set; }

	[JsonPropertyName("value5_bool")]
	public Boolean? Value5Bool { get; set; }
	[JsonPropertyName("value6")]

	public String? Value6 { get; set; }

	[JsonPropertyName("value6_bool")]
	public Boolean? Value6Bool { get; set; }
	[JsonPropertyName("value7")]

	public String? Value7 { get; set; }

	[JsonPropertyName("value7_bool")]
	public Boolean? Value7Bool { get; set; }
	[JsonPropertyName("value8")]

	public String? Value8 { get; set; }

	[JsonPropertyName("value8_bool")]
	public Boolean? Value8Bool { get; set; }
	[JsonPropertyName("value9")]

	public String? Value9 { get; set; }

	[JsonPropertyName("value9_bool")]
	public Boolean? Value9Bool { get; set; }
	[JsonPropertyName("valueint1")]
	public Int32? Valueint1 { get; set; }
	[JsonPropertyName("_warning")]

	public String? Warning { get; set; }

	[JsonPropertyName("xero_tenant_name")]

	public String? XeroTenantName { get; set; }
}

