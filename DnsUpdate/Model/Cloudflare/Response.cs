using System.Text.Json.Serialization;

namespace DnsUpdate.Model.Cloudflare;

internal record Response
{
    [JsonPropertyName("success")]
    public bool Success { get; init; } = false;
    
    [JsonPropertyName("errors")]
    public string[] Errors { get; init; } = null!;

    [JsonPropertyName("messages")]
    public string[] Messages { get; init; } = null!;
    
}