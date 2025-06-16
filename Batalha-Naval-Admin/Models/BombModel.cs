using System.Text.Json.Serialization;

public class BombModel
{
    [JsonPropertyName("bomb_id")]
    public int BombId { get; set; }

    [JsonPropertyName("bomb_name")]
    public string? BombName { get; set; }

    [JsonPropertyName("bomb_price")]
    public int BombPrice { get; set; }

    [JsonPropertyName("bomb_image")]
    public string? BombImage { get; set; }

    [JsonPropertyName("bomb_desc")]
    public string? BombDesc { get; set; }

    [JsonPropertyName("bomb_type")]
    public int BombType { get; set; }
}
