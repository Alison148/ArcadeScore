using System;

namespace ArcadeScore.Api.Models
{
    public class ScoreEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Player { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
