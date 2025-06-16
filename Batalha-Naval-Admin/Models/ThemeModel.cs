using System.Text.Json.Serialization;

public class ThemeModel
{
    [JsonPropertyName("theme_id")]
    public int ThemeId { get; set; }

    [JsonPropertyName("theme_name")]
    public string? ThemeName { get; set; }

    [JsonPropertyName("theme_image")]
    public string? ThemeImage { get; set; }

    [JsonPropertyName("theme_preview")]
    public string? ThemePreview { get; set; }

    [JsonPropertyName("theme_price")]
    public int ThemePrice { get; set; }
}
