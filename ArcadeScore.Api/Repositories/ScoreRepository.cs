using System.Collections.Generic;
using System.Linq;
using ArcadeScore.Api.Models;

namespace ArcadeScore.Api.Repositories
{
    public class ScoreRepository
    {
        private readonly List<ScoreEntry> _scores = new List<ScoreEntry>();

        public void Add(ScoreEntry entry)
        {
            _scores.Add(entry);
        }

        public List<ScoreEntry> GetAll()
        {
            return _scores.ToList();
        }

        public List<ScoreEntry> GetTopScores(int count)
        {
            return _scores.OrderByDescending(s => s.Score).ThenBy(s => s.Date).Take(count).ToList();
        }

        public List<ScoreEntry> GetByPlayer(string player)
        {
            return _scores.Where(s => s.Player == player).OrderBy(s => s.Date).ToList();
        }
    }
}
