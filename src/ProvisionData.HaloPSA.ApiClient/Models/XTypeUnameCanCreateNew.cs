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

public class XTypeUnameCanCreateNew
{
    [JsonPropertyName("id")]
    public Int32 Id { get; set; }

    [JsonPropertyName("create")]
    public Boolean Create { get; set; }

    [JsonPropertyName("read")]
    public Boolean Read { get; set; }

    [JsonPropertyName("edit")]
    public Boolean Edit { get; set; }

    [JsonPropertyName("viewatt")]
    public Boolean ViewAtt { get; set; }

    [JsonPropertyName("uploadatt")]
    public Boolean UploadAtt { get; set; }

    [JsonPropertyName("downloadatt")]
    public Boolean DownloadAtt { get; set; }

    [JsonPropertyName("editatt")]
    public Boolean EditAtt { get; set; }

    [JsonPropertyName("viewactionhistory")]
    public Boolean ViewActionHistory { get; set; }
}
