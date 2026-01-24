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

public class User
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;
    [JsonPropertyName("site_id")]
    public Int32 SiteId { get; set; }

    [JsonPropertyName("site_id_int")]
    public Int32 SiteIdInt { get; set; }

    [JsonPropertyName("site_name")]
    public String SiteName { get; set; } = String.Empty;
    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;
    [JsonPropertyName("firstname")]
    public String Firstname { get; set; } = String.Empty;
    [JsonPropertyName("surname")]
    public String Surname { get; set; } = String.Empty;
    [JsonPropertyName("initials")]
    public String Initials { get; set; } = String.Empty;
    [JsonPropertyName("title")]
    public String Title { get; set; } = String.Empty;
    [JsonPropertyName("emailaddress")]
    public String Emailaddress { get; set; } = String.Empty;
    [JsonPropertyName("phonenumber_preferred")]
    public String PhonenumberPreferred { get; set; } = String.Empty;
    [JsonPropertyName("sitephonenumber")]
    public String Sitephonenumber { get; set; } = String.Empty;
    [JsonPropertyName("phonenumber")]
    public String Phonenumber { get; set; } = String.Empty;
    [JsonPropertyName("homenumber")]
    public String Homenumber { get; set; } = String.Empty;
    [JsonPropertyName("mobilenumber")]
    public String Mobilenumber { get; set; } = String.Empty;
    [JsonPropertyName("mobilenumber2")]
    public String Mobilenumber2 { get; set; } = String.Empty;
    [JsonPropertyName("fax")]
    public String Fax { get; set; } = String.Empty;
    [JsonPropertyName("telpref")]
    public Int32 Telpref { get; set; }

    [JsonPropertyName("activedirectory_dn")]
    public String ActivedirectoryDn { get; set; } = String.Empty;
    [JsonPropertyName("onpremise_activedirectory_dn")]
    public String OnpremiseActivedirectoryDn { get; set; } = String.Empty;
    [JsonPropertyName("container_dn")]
    public String ContainerDn { get; set; } = String.Empty;
    [JsonPropertyName("login")]
    public String Login { get; set; } = String.Empty;
    [JsonPropertyName("inactive")]
    public Boolean Inactive { get; set; }

    [JsonPropertyName("colour")]
    public String Colour { get; set; } = String.Empty;
    [JsonPropertyName("isimportantcontact")]
    public Boolean Isimportantcontact { get; set; }

    [JsonPropertyName("other1")]
    public String Other1 { get; set; } = String.Empty;
    [JsonPropertyName("other2")]
    public String Other2 { get; set; } = String.Empty;
    [JsonPropertyName("other3")]
    public String Other3 { get; set; } = String.Empty;
    [JsonPropertyName("other4")]
    public String Other4 { get; set; } = String.Empty;
    [JsonPropertyName("other5")]
    public String Other5 { get; set; } = String.Empty;
    [JsonPropertyName("notes")]
    public String Notes { get; set; } = String.Empty;
    [JsonPropertyName("neversendemails")]
    public Boolean Neversendemails { get; set; }

    [JsonPropertyName("default_currency_code")]
    public Int32 DefaultCurrencyCode { get; set; }

    [JsonPropertyName("site_guid")]
    public String SiteGuid { get; set; } = String.Empty;
    [JsonPropertyName("area_guid")]
    public String AreaGuid { get; set; } = String.Empty;
    [JsonPropertyName("site_cautomate_guid")]
    public String SiteCautomateGuid { get; set; } = String.Empty;
    [JsonPropertyName("priority_id")]
    public Int32 PriorityId { get; set; }

    [JsonPropertyName("linked_agent_id")]
    public Int32 LinkedAgentId { get; set; }

    [JsonPropertyName("covered_by_contract")]
    public Boolean CoveredByContract { get; set; }

    [JsonPropertyName("contract_value")]
    public Int32 ContractValue { get; set; }

    [JsonPropertyName("software_role_name")]
    public String SoftwareRoleName { get; set; } = String.Empty;
    [JsonPropertyName("customfields")]
    public List<CustomField> Customfields { get; set; } = [];

    [JsonPropertyName("attachments")]
    public List<Attachment> Attachments { get; set; } = [];

    [JsonPropertyName("custombuttons")]
    public List<CustomButton> Custombuttons { get; set; } = [];

    [JsonPropertyName("relationship_id")]
    public Int32 RelationshipId { get; set; }

    [JsonPropertyName("user_relationships")]
    public List<UserRelationship> UserRelationships { get; set; } = [];

    [JsonPropertyName("uddevsite")]
    public Int32 Uddevsite { get; set; }

    [JsonPropertyName("uddevnum")]
    public Int32 Uddevnum { get; set; }

    [JsonPropertyName("uduserid")]
    public Int32 Uduserid { get; set; }

    [JsonPropertyName("userdevicerolecount")]
    public Int32 Userdevicerolecount { get; set; }

    [JsonPropertyName("site_hubspot_guid")]
    public String SiteHubspotGuid { get; set; } = String.Empty;
    [JsonPropertyName("isserviceaccount")]
    public Boolean Isserviceaccount { get; set; }

    [JsonPropertyName("ignoreautomatedbilling")]
    public Boolean Ignoreautomatedbilling { get; set; }

    [JsonPropertyName("isimportantcontact2")]
    public Boolean Isimportantcontact2 { get; set; }

    [JsonPropertyName("connectwiseid")]
    public Int32 Connectwiseid { get; set; }

    [JsonPropertyName("autotaskid")]
    public Int32 Autotaskid { get; set; }

    [JsonPropertyName("messagegroup_id")]
    public Int32 MessagegroupId { get; set; }

    [JsonPropertyName("role_list")]
    public String RoleList { get; set; } = String.Empty;
    [JsonPropertyName("sitetimezone")]
    public String Sitetimezone { get; set; } = String.Empty;
    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;
    [JsonPropertyName("client_id")]
    public Int32 ClientId { get; set; }

    [JsonPropertyName("item_tax_code")]
    public Int32 ItemTaxCode { get; set; }

    [JsonPropertyName("automatic_sales_tax")]
    public Boolean AutomaticSalesTax { get; set; }

    [JsonPropertyName("client_taxable")]
    public Boolean ClientTaxable { get; set; }

    [JsonPropertyName("overridepdftemplatequote")]
    public Int32 Overridepdftemplatequote { get; set; }

    [JsonPropertyName("overridepdftemplatequote_name")]
    public String OverridepdftemplatequoteName { get; set; } = String.Empty;
    [JsonPropertyName("contract_end_date")]
    public DateTime ContractEndDate { get; set; } = DateTime.UnixEpoch;

    [JsonPropertyName("okta_id")]
    public String OktaId { get; set; } = String.Empty;
    [JsonPropertyName("azure_id")]
    public String AzureId { get; set; } = String.Empty;
    [JsonPropertyName("user_with_clientsite")]
    public String UserWithClientsite { get; set; } = String.Empty;
}
