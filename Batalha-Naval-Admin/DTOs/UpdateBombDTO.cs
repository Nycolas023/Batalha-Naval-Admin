namespace Batalha_Naval_Admin.DTOs
{
    public class UpdateBombDTO
    {
        public int BombId { get; set; }
        public string? BombName { get; set; }
        public int BombPrice { get; set; }
        public string? BombImage { get; set; }
        public string? BombDesc { get; set; }
        public int BombType { get; set; }
    }
}
