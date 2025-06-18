using System;
using System.Collections.Generic;
using System.Linq;
using ArcadeScore.Api.Models;
using ArcadeScore.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ArcadeScore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoresController : ControllerBase
    {
        private static readonly ScoreRepository _repository = new ScoreRepository();

        [HttpPost]
        public IActionResult RegisterScore([FromBody] ScoreEntry entry)
        {
            if (string.IsNullOrWhiteSpace(entry.Player) || entry.Score < 0)
                return BadRequest("Dados inválidos.");
            _repository.Add(entry);
            return Ok(entry);
        }

        [HttpGet("ranking")]
        public IActionResult GetRanking()
        {
            var topScores = _repository.GetTopScores(10);
            return Ok(topScores);
        }

        [HttpGet("player/{player}")]
        public IActionResult GetPlayerStats(string player)
        {
            var scores = _repository.GetByPlayer(player);
            if (!scores.Any())
                return NotFound("Jogador não encontrado.");

            var partidas = scores.Count;
            var media = scores.Average(s => s.Score);
            var maior = scores.Max(s => s.Score);
            var menor = scores.Min(s => s.Score);
            var recordes = 0;
            var recordeAtual = int.MinValue;
            foreach (var s in scores)
            {
                if (s.Score > recordeAtual)
                {
                    recordeAtual = s.Score;
                    recordes++;
                }
            }
            var tempoJogo = scores.Last().Date - scores.First().Date;
            return Ok(new
            {
                Jogador = player,
                Partidas = partidas,
                Media = media,
                Maior = maior,
                Menor = menor,
                Recordes = recordes,
                TempoJogo = tempoJogo.TotalDays >= 1 ? $"{tempoJogo.TotalDays:F0} dias" : $"{tempoJogo.TotalHours:F0} horas"
            });
        }
    }
}
