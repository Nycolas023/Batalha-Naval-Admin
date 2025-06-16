using System.Text.Json.Serialization;

public class ShipModel
{
    [JsonPropertyName("ship_id")]
    public int ShipId { get; set; }

    [JsonPropertyName("ship_name")]
    public string? ShipName { get; set; }

    [JsonPropertyName("ship_image")]
    public string? ShipImage { get; set; }

    [JsonPropertyName("ship_desc")]
    public string? ShipDesc { get; set; }

    [JsonPropertyName("ship_size")]
    public int ShipSize { get; set; }

    [JsonPropertyName("theme_id")]
    public int ThemeId { get; set; }
}
