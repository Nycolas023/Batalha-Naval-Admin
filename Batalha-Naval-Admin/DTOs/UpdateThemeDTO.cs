namespace Batalha_Naval_Admin.DTOs
{
    public class UpdateThemeDTO
    {
        public int ThemeId { get; set; }
        public string? ThemeName { get; set; }
        public string? ThemeImage { get; set; }
        public string? ThemePreview { get; set; }
        public int ThemePrice { get; set; }
    }
}
