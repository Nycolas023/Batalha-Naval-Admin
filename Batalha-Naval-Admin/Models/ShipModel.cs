namespace Batalha_Naval_Admin.Models
{
    public class ShipModel
    {
        public int ShipId { get; set; }
        public string ShipImage { get; set; } = string.Empty;
        public string ShipName { get; set; } = string.Empty;
        public string ShipDesc { get; set; } = string.Empty;
        public string ShipSize { get; set; } = string.Empty;
        public int ThemeId { get; set; }
    }
}
