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

public partial class UsersList

{
	[JsonPropertyName("activedirectory_dn")]

	public String? ActivedirectoryDn { get; set; }

	[JsonPropertyName("approver_note_hint")]

	public String? ApproverNoteHint { get; set; }

	[JsonPropertyName("area_guid")]

	public String? AreaGuid { get; set; }

	//[JsonPropertyName("attachments")]
	//public List<UntypedNode>? Attachments { get; set; }

	[JsonPropertyName("automatic_sales_tax")]
	public Boolean? AutomaticSalesTax { get; set; }
	[JsonPropertyName("autotaskid")]
	public Int32? Autotaskid { get; set; }
	[JsonPropertyName("avalara_tenant")]
	public Int32? AvalaraTenant { get; set; }
	[JsonPropertyName("azure_id")]

	public String? AzureId { get; set; }

	[JsonPropertyName("azureoid")]

	public String? Azureoid { get; set; }

	[JsonPropertyName("client_account_manager_id")]
	public Int32? ClientAccountManagerId { get; set; }
	[JsonPropertyName("client_automatic_callscript_id")]
	public Int32? ClientAutomaticCallscriptId { get; set; }
	[JsonPropertyName("client_id")]
	public Int32? ClientId { get; set; }
	[JsonPropertyName("client_name")]

	public String? ClientName { get; set; }

	[JsonPropertyName("client_taxable")]
	public Boolean? ClientTaxable { get; set; }
	[JsonPropertyName("colour")]

	public String? Colour { get; set; }

	[JsonPropertyName("connectwiseid")]
	public Int32? Connectwiseid { get; set; }
	[JsonPropertyName("container_dn")]

	public String? ContainerDn { get; set; }

	[JsonPropertyName("contract_end_date")]
	public DateTimeOffset? ContractEndDate { get; set; }
	[JsonPropertyName("contract_value")]
	public Double? ContractValue { get; set; }
	[JsonPropertyName("covered_by_contract")]
	public Boolean? CoveredByContract { get; set; }
	[JsonPropertyName("custombuttons")]

	public List<CustomButton>? CustomButtons { get; set; }

	[JsonPropertyName("customfields")]

	public List<CustomField>? CustomFields { get; set; }

	[JsonPropertyName("date_of_birth")]
	public DateTimeOffset? DateOfBirth { get; set; }
	[JsonPropertyName("default_currency_code")]
	public Int32? DefaultCurrencyCode { get; set; }
	[JsonPropertyName("email2")]

	public String? Email2 { get; set; }

	[JsonPropertyName("email3")]

	public String? Email3 { get; set; }

	[JsonPropertyName("emailaddress")]

	public String? Emailaddress { get; set; }

	[JsonPropertyName("fax")]

	public String? Fax { get; set; }

	[JsonPropertyName("firstname")]

	public String? Firstname { get; set; }

	[JsonPropertyName("homenumber")]

	public String? Homenumber { get; set; }

	[JsonPropertyName("id")]
	public Int32? Id { get; set; }
	[JsonPropertyName("ignoreautomatedbilling")]
	public Boolean? Ignoreautomatedbilling { get; set; }
	[JsonPropertyName("import_details_id")]
	public Int32? ImportDetailsId { get; set; }
	[JsonPropertyName("_importthirdpartyid")]

	public String? Importthirdpartyid { get; set; }

	[JsonPropertyName("_importtype")]

	public String? Importtype { get; set; }

	[JsonPropertyName("_importtypeid")]
	public Int32? Importtypeid { get; set; }
	[JsonPropertyName("inactive")]
	public Boolean? Inactive { get; set; }
	[JsonPropertyName("initials")]

	public String? Initials { get; set; }

	[JsonPropertyName("isimportantcontact")]
	public Boolean? Isimportantcontact { get; set; }
	[JsonPropertyName("isimportantcontact2")]
	public Boolean? Isimportantcontact2 { get; set; }
	[JsonPropertyName("is_prospect")]
	public Boolean? IsProspect { get; set; }
	[JsonPropertyName("isserviceaccount")]
	public Boolean? Isserviceaccount { get; set; }
	[JsonPropertyName("_isupdateimport")]
	public Boolean? Isupdateimport { get; set; }
	[JsonPropertyName("item_tax_code")]
	public Int32? ItemTaxCode { get; set; }
	[JsonPropertyName("key")]
	public Int32? Key { get; set; }
	[JsonPropertyName("language_id")]
	public Int32? LanguageId { get; set; }
	[JsonPropertyName("linked_agent_id")]
	public Int32? LinkedAgentId { get; set; }
	[JsonPropertyName("login")]

	public String? Login { get; set; }

	[JsonPropertyName("messagegroup_id")]
	public Int32? MessagegroupId { get; set; }
	[JsonPropertyName("mobilenumber")]

	public String? Mobilenumber { get; set; }

	[JsonPropertyName("mobilenumber2")]

	public String? Mobilenumber2 { get; set; }

	[JsonPropertyName("name")]

	public String? Name { get; set; }

	[JsonPropertyName("neversendemails")]
	public Boolean? Neversendemails { get; set; }
	[JsonPropertyName("neversendmarketingemails")]
	public Boolean? Neversendmarketingemails { get; set; }
	[JsonPropertyName("new_external_link")]

	public ExternalLinkList? NewExternalLink { get; set; }

	[JsonPropertyName("notes")]

	public String? Notes { get; set; }

	[JsonPropertyName("okta_id")]

	public String? OktaId { get; set; }

	[JsonPropertyName("onpremise_activedirectory_dn")]

	public String? OnpremiseActivedirectoryDn { get; set; }

	[JsonPropertyName("other1")]

	public String? Other1 { get; set; }

	[JsonPropertyName("other2")]

	public String? Other2 { get; set; }

	[JsonPropertyName("other3")]

	public String? Other3 { get; set; }

	[JsonPropertyName("other4")]

	public String? Other4 { get; set; }

	[JsonPropertyName("other5")]

	public String? Other5 { get; set; }

	[JsonPropertyName("overridepdftemplatequote")]
	public Int32? Overridepdftemplatequote { get; set; }
	[JsonPropertyName("overridepdftemplatequote_name")]

	public String? OverridepdftemplatequoteName { get; set; }

	[JsonPropertyName("phonenumber")]

	public String? Phonenumber { get; set; }

	[JsonPropertyName("phonenumber_preferred")]

	public String? PhonenumberPreferred { get; set; }

	[JsonPropertyName("priority_id")]
	public Int32? PriorityId { get; set; }
	[JsonPropertyName("relationship_id")]
	public Int32? RelationshipId { get; set; }
	[JsonPropertyName("role_ids")]

	public List<Int32?>? RoleIds { get; set; }

	[JsonPropertyName("role_list")]

	public String? RoleList { get; set; }

	[JsonPropertyName("site_cautomate_guid")]

	public String? SiteCautomateGuid { get; set; }

	[JsonPropertyName("site_guid")]

	public String? SiteGuid { get; set; }

	[JsonPropertyName("site_hubspot_guid")]

	public String? SiteHubspotGuid { get; set; }

	[JsonPropertyName("site_id")]
	public Double? SiteId { get; set; }
	[JsonPropertyName("site_id_int")]
	public Int32? SiteIdInt { get; set; }
	[JsonPropertyName("site_name")]

	public String? SiteName { get; set; }

	[JsonPropertyName("sitephonenumber")]

	public String? Sitephonenumber { get; set; }

	[JsonPropertyName("sitetimezone")]

	public String? Sitetimezone { get; set; }

	[JsonPropertyName("software_role_name")]

	public String? SoftwareRoleName { get; set; }

	[JsonPropertyName("surname")]

	public String? Surname { get; set; }

	//[JsonPropertyName("table")]
	//public UntypedNode? Table { get; set; }

	[JsonPropertyName("telpref")]
	public Int32? Telpref { get; set; }
	[JsonPropertyName("title")]

	public String? Title { get; set; }

	[JsonPropertyName("uddevnum")]
	public Int32? Uddevnum { get; set; }
	[JsonPropertyName("uddevsite")]
	public Int32? Uddevsite { get; set; }
	[JsonPropertyName("uduserid")]
	public Int32? Uduserid { get; set; }
	[JsonPropertyName("use")]

	public String? Use { get; set; }

	[JsonPropertyName("userdevicerolecount")]
	public Int32? Userdevicerolecount { get; set; }

	//[JsonPropertyName("user_relationships")]
	//public List<UntypedNode>? UserRelationships { get; set; }

	[JsonPropertyName("user_with_clientsite")]

	public String? UserWithClientsite { get; set; }

	[JsonPropertyName("whatsapp_number")]

	public String? WhatsappNumber { get; set; }

}

