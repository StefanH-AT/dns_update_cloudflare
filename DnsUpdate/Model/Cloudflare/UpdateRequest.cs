using System.Text.Json.Serialization;

namespace DnsUpdate.Model.Cloudflare;

internal record UpdateRequest {
    
    [JsonPropertyName("type")]
    public required string Type { get; init; }
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("content")]
    public required string Content { get; init; }
    [JsonPropertyName("proxied")]
    public bool Proxied { get; init; }
    [JsonPropertyName("ttl")]
    public int TimeToLive { get; init; }
    
}