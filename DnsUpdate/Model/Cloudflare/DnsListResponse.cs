using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DnsUpdate.Model.Cloudflare;

internal record DnsListResponse : Response
{
    [JsonPropertyName("result")]
    public required List<DnsListResult> Result { get; init; }
}