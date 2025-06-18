import { Component } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-ranking',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './ranking.html',
  styleUrl: './ranking.css'
})
export class RankingComponent {
  scores: any[] = [];
  errorMessage = '';

  constructor(private http: HttpClient) {
    this.loadRanking();
  }

  loadRanking() {
    this.http.get<any[]>('https://localhost:5001/api/scores/ranking').subscribe({
      next: (data) => this.scores = data,
      error: (err) => this.errorMessage = err.error || 'Erro ao carregar ranking.'
    });
  }
}
