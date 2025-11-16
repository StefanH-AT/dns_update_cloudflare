using System.Text.Json.Serialization;

namespace DnsUpdate.Model.Cloudflare;

internal record Meta
{
    [JsonPropertyName("auto_added")]
    public bool AutoAdded { get; init; }
    [JsonPropertyName("source")]
    public required string Source { get; init; }
}