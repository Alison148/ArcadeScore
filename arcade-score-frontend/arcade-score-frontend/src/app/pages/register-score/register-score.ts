import { Component } from '@angular/core';
import { NgForm, FormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-register-score',
  standalone: true,
  imports: [FormsModule, HttpClientModule],
  templateUrl: './register-score.html',
  styleUrl: './register-score.css'
})
export class RegisterScoreComponent {
  player = '';
  score: number | null = null;
  date = '';
  successMessage = '';
  errorMessage = '';

  constructor(private http: HttpClient) {}

  onSubmit() {
    this.successMessage = '';
    this.errorMessage = '';
    const entry = {
      player: this.player,
      score: this.score,
      date: this.date
    };
    this.http.post('https://localhost:5001/api/scores', entry).subscribe({
      next: () => {
        this.successMessage = 'Pontuação registrada com sucesso!';
        this.player = '';
        this.score = null;
        this.date = '';
      },
      error: (err) => {
        this.errorMessage = err.error || 'Erro ao registrar pontuação.';
      }
    });
  }
}
