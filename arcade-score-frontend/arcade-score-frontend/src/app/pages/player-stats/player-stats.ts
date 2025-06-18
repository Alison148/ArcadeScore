import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-player-stats',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './player-stats.html',
  styleUrl: './player-stats.css'
})
export class PlayerStatsComponent {
  stats: any = null;
  errorMessage = '';

  constructor(private route: ActivatedRoute, private http: HttpClient) {
    this.route.paramMap.subscribe(params => {
      const player = params.get('player');
      if (player) {
        this.loadStats(player);
      }
    });
  }

  loadStats(player: string) {
    this.stats = null;
    this.errorMessage = '';
    this.http.get<any>(`https://localhost:5001/api/scores/player/${player}`).subscribe({
      next: (data) => this.stats = data,
      error: (err) => this.errorMessage = err.error || 'Erro ao carregar estatísticas.'
    });
  }
}
