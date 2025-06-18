namespace ArcadeScore.Api.Models
{
    public class PlayerStats
    {
        public string Jogador { get; set; }
        public int Partidas { get; set; }
        public double Media { get; set; }
        public int Maior { get; set; }
        public int Menor { get; set; }
        public int Recordes { get; set; }
        public string TempoJogo { get; set; }
    }
}
