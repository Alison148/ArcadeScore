import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', redirectTo: 'register-score', pathMatch: 'full' },
  { path: 'register-score', loadComponent: () => import('./pages/register-score/register-score').then(m => m.RegisterScoreComponent) },
  { path: 'ranking', loadComponent: () => import('./pages/ranking/ranking').then(m => m.RankingComponent) },
  { path: 'player/:player', loadComponent: () => import('./pages/player-stats/player-stats').then(m => m.PlayerStatsComponent) },
];
