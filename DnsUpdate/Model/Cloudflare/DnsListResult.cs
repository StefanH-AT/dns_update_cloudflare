using System;
using System.Text.Json.Serialization;

namespace DnsUpdate.Model.Cloudflare;

internal record DnsListResult
{
    [JsonPropertyName("data")]
    public required Object Data { get; init; }
    
    [JsonPropertyName("meta")]
    public required Meta Meta { get; init; }
    
    [JsonPropertyName("id")]
    public required string Id { get; init; }
    
    [JsonPropertyName("type")]
    public required string Type { get; init; }
    
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    [JsonPropertyName("proxiable")] 
    public bool Proxiable { get; init; } = false;
    
    [JsonPropertyName("proxied")]
    public bool Proxied { get; init; } = false;
    
    [JsonPropertyName("ttl")]
    public int TimeToLive { get; init; } = 0;
    
    [JsonPropertyName("locked")]
    public bool Locked { get; init; } = false;
    
    [JsonPropertyName("zone_id")]
    public string ZoneId { get; init; } = null!;
    
    [JsonPropertyName("zone_name")]
    public string ZoneName { get; init; } = null!;
    
    [JsonPropertyName("created_on")]
    public string CreatedOn { get; init; } = null!;
    
    [JsonPropertyName("modified_on")]
    public string ModifiedOn { get; init; } = null!;
}