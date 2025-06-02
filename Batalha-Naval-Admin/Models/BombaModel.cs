namespace Batalha_Naval_Admin.Models
{
    public class BombaModel
    {
        public int BombaId { get; set; }
        public string BombaName { get; set; } = string.Empty;
        public string BombaDesc { get; set; } = string.Empty;
        public string BombaImage {  get; set; } = string.Empty;
        public int BombaPrice { get; set; }
        public int BombaType { get; set; }

    }
}
