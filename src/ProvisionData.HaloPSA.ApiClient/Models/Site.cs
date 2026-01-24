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

public record Site
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("name")]
    public String Name { get; set; } = String.Empty;

    [JsonPropertyName("client_id")]
    public Decimal ClientId { get; set; }

    [JsonPropertyName("client_name")]
    public String ClientName { get; set; } = String.Empty;

    [JsonPropertyName("clientsite_name")]
    public String ClientsiteName { get; set; } = String.Empty;

    [JsonPropertyName("inactive")]
    public Boolean Inactive { get; set; }

    [JsonPropertyName("sla_id")]
    public Int32 SlaId { get; set; }

    [JsonPropertyName("phonenumber")]
    public String Phonenumber { get; set; } = String.Empty;

    [JsonPropertyName("colour")]
    public String Colour { get; set; } = String.Empty;

    [JsonPropertyName("timezone")]
    public String Timezone { get; set; } = String.Empty;

    [JsonPropertyName("invoice_address_isdelivery")]
    public Boolean InvoiceAddressIsdelivery { get; set; }

    [JsonPropertyName("isstocklocation")]
    public Boolean Isstocklocation { get; set; }

    [JsonPropertyName("messagegroup_id")]
    public Int32 MessagegroupId { get; set; }

    [JsonPropertyName("datecreated")]
    public DateTime Datecreated { get; set; }

    [JsonPropertyName("emaildomain")]
    public String Emaildomain { get; set; } = String.Empty;

    [JsonPropertyName("isinvoicesite")]
    public Boolean IsinvoiceSite { get; set; }

    [JsonPropertyName("refnumber")]
    public Int32 Refnumber { get; set; }

    [JsonPropertyName("defaultdelivery")]
    public Boolean Defaultdelivery { get; set; }

    [JsonPropertyName("stopped")]
    public Int32 Stopped { get; set; }

    [JsonPropertyName("sitedateformat")]
    public Int32 Sitedateformat { get; set; }

    [JsonPropertyName("contractlastchecked")]
    public DateTime Contractlastchecked { get; set; }

    [JsonPropertyName("maincontact_name")]
    public String MaincontactName { get; set; } = String.Empty;

    [JsonPropertyName("language_id")]
    public Int32 LanguageId { get; set; }

    [JsonPropertyName("slocked")]
    public Boolean Slocked { get; set; }

    [JsonPropertyName("client")]
    public Client? Client { get; set; }

    [JsonPropertyName("fields")]
    public List<Field> Fields { get; set; } = [];

    [JsonPropertyName("ninjarmmid")]
    public Int32 Ninjarmmid { get; set; }

    [JsonPropertyName("servicenowid")]
    public String Servicenowid { get; set; } = String.Empty;

    [JsonPropertyName("isnhserveremaildefault")]
    public Boolean Isnhserveremaildefault { get; set; }

    [JsonPropertyName("datto_id")]
    public String DattoId { get; set; } = String.Empty;

    [JsonPropertyName("datto_alternate_id")]
    public Int32 DattoAlternateId { get; set; }

    [JsonPropertyName("datto_url")]
    public String DattoUrl { get; set; } = String.Empty;

    [JsonPropertyName("connectwiseid")]
    public Int32 Connectwiseid { get; set; }

    [JsonPropertyName("azuretenantid")]
    public String Azuretenantid { get; set; } = String.Empty;

    [JsonPropertyName("autotaskid")]
    public Int32 Autotaskid { get; set; }

    [JsonPropertyName("pagerdutywildcard")]
    public String Pagerdutywildcard { get; set; } = String.Empty;

    [JsonPropertyName("ateraid")]
    public Int32 Ateraid { get; set; }

    [JsonPropertyName("slastupdate")]
    public DateTime Slastupdate { get; set; }

    [JsonPropertyName("site_service_tax_code")]
    public Int32 SiteServiceTaxCode { get; set; }

    [JsonPropertyName("site_prepay_tax_code")]
    public Int32 SitePrepayTaxCode { get; set; }

    [JsonPropertyName("site_contract_tax_code")]
    public Int32 SiteContractTaxCode { get; set; }

    [JsonPropertyName("site_purchase_tax_code")]
    public Int32 SitePurchaseTaxCode { get; set; }

    [JsonPropertyName("syncroid")]
    public Int32 Syncroid { get; set; }

    [JsonPropertyName("auvik_id")]
    public String AuvikId { get; set; } = String.Empty;

    [JsonPropertyName("all_faqlists_allowed")]
    public Boolean AllFaqlistsAllowed { get; set; }

    [JsonPropertyName("hubspot_id")]
    public String HubspotId { get; set; } = String.Empty;

    [JsonPropertyName("passportal_id")]
    public Int32 PassportalId { get; set; }

    [JsonPropertyName("liongardid")]
    public Int32 Liongardid { get; set; }

    [JsonPropertyName("country_code")]
    public String CountryCode { get; set; } = String.Empty;

    [JsonPropertyName("region_code")]
    public Int32 RegionCode { get; set; }

    [JsonPropertyName("use")]
    public String Use { get; set; } = String.Empty;

    [JsonPropertyName("itglue_id")]
    public String ItglueId { get; set; } = String.Empty;

    [JsonPropertyName("maincontact_id")]
    public Int32 MaincontactId { get; set; }

    [JsonPropertyName("site_item_tax_code")]
    public Int32 SiteItemTaxCode { get; set; }

    public List<Address> Addresses { get; set; } = [];

 
}
