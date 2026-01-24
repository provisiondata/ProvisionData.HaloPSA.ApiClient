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

public class Attachment
{
	[JsonPropertyName("third_party_id")]
    public String ThirdPartyId { get; set; } = String.Empty;
	[JsonPropertyName("link")]
    public String Link { get; set; } = String.Empty;
	[JsonPropertyName("content_type")]
    public String ContentType { get; set; } = String.Empty;
	[JsonPropertyName("id")]
	public Int32 Id { get; set; }

	[JsonPropertyName("filename")]
    public String Filename { get; set; } = String.Empty;
	[JsonPropertyName("datecreated")]
	public DateTime Datecreated { get; set; } = DateTime.UnixEpoch;

	[JsonPropertyName("note")]
    public String Note { get; set; } = String.Empty;
	[JsonPropertyName("filesize")]
	public Int32 Filesize { get; set; }

	[JsonPropertyName("type")]
	public Int32 Type { get; set; }

	[JsonPropertyName("unique_id")]
	public Int32 UniqueId { get; set; }

	[JsonPropertyName("desc")]
    public String Desc { get; set; } = String.Empty;
	[JsonPropertyName("isimage")]
	public Boolean Isimage { get; set; }

	[JsonPropertyName("data")]
    public String Data { get; set; } = String.Empty;
	[JsonPropertyName("ticket_id")]
	public Int32 TicketId { get; set; }

	[JsonPropertyName("action_id")]
	public Int32 ActionId { get; set; }

	[JsonPropertyName("user_id")]
	public Int32 UserId { get; set; }

	[JsonPropertyName("agent_id")]
	public Int32 AgentId { get; set; }

	[JsonPropertyName("attachmentaction_id")]
	public Int32 AttachmentactionId { get; set; }

	[JsonPropertyName("_canupdate")]
	public Boolean Canupdate { get; set; }

	[JsonPropertyName("guid")]
    public String Guid { get; set; } = String.Empty;
	[JsonPropertyName("image_upload_id")]
	public Int32 ImageUploadId { get; set; }

	[JsonPropertyName("image_upload_key")]
    public String ImageUploadKey { get; set; } = String.Empty;
	[JsonPropertyName("file")]
    public String File { get; set; } = String.Empty;
	[JsonPropertyName("_enduserportalpdfprint")]
	public Boolean Enduserportalpdfprint { get; set; }

	[JsonPropertyName("anon_outcomeid")]
	public Int32 AnonOutcomeid { get; set; }

	[JsonPropertyName("has_scanned")]
	public Boolean HasScanned { get; set; }

	[JsonPropertyName("_warning")]
    public String Warning { get; set; } = String.Empty;
	[JsonPropertyName("showforusers")]
	public Boolean Showforusers { get; set; }

	[JsonPropertyName("showonchild")]
	public Boolean Showonchild { get; set; }

	[JsonPropertyName("showonrelated")]
	public Boolean Showonrelated { get; set; }

	[JsonPropertyName("data_base64")]
    public String DataBase64 { get; set; } = String.Empty;
	[JsonPropertyName("download_url")]
    public String DownloadUrl { get; set; } = String.Empty;
	[JsonPropertyName("third_party_token")]
    public String ThirdPartyToken { get; set; } = String.Empty;
	[JsonPropertyName("already_posted")]
	public Boolean AlreadyPosted { get; set; }

	[JsonPropertyName("faultid")]
	public Int32 Faultid { get; set; }

	[JsonPropertyName("_isimport")]
	public Boolean Isimport { get; set; }

	[JsonPropertyName("_importtype")]
    public String Importtype { get; set; } = String.Empty;
	[JsonPropertyName("s3url")]
    public String S3url { get; set; } = String.Empty;
	[JsonPropertyName("att_link")]
    public String AttLink { get; set; } = String.Empty;
}
