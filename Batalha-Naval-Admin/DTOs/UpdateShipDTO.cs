﻿using System.Text.Json.Serialization;

namespace Batalha_Naval_Admin.DTOs
{
    public class UpdateShipDTO
    {
        public int ShipId { get; set; }
        public string? ShipName { get; set; }
        public string? ShipImage { get; set; }
        public string? ShipDesc { get; set; }
        public int ShipSize { get; set; }
        public int ThemeId { get; set; }
    }
}
