namespace Batalha_Naval_Admin.Models
{
    public class BombModel
    {
        public int BombId { get; set; }
        public string BombName { get; set; } = string.Empty;
        public string BombDesc { get; set; } = string.Empty;
        public string BombImage {  get; set; } = string.Empty;
        public int BombPrice { get; set; }
        public int BombType { get; set; }

    }
}
