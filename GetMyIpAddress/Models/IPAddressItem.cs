namespace GetMyIpAddress;
using System.Text.Json;
using System.Text.Json.Serialization;

public class IPAddressItem
{
    [JsonPropertyName("ip")]
    public string? address { get; set; }
}