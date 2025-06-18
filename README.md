# ArcadeScore

## Descrição
Aplicação para registrar pontuações de fliperama, consultar ranking e estatísticas de jogadores.

## Como executar

### 1. API .NET (Back-end)
1. Abra o terminal na pasta `ArcadeScore.Api`.
2. Execute:
   ```powershell
   dotnet run
   ```
3. A API estará disponível em: `https://localhost:5055` (Swagger em `/swagger`).

### 2. Front-end Angular
1. Abra o terminal na pasta `arcade-score-frontend/arcade-score-frontend`.
2. Execute:
   ```powershell
   npm install
   npm start
   ```
3. Acesse: `http://localhost:4200`

> **Obs:**
> - Certifique-se de que a API está rodando antes de usar o front-end.
> - O front-end está configurado para consumir a API em `https://localhost:5055`.

## Funcionalidades
- Registrar pontuação (data, jogador, pontuação)
- Visualizar ranking (top 10)
- Visualizar estatísticas detalhadas do jogador

## Observações
- Não utiliza banco de dados, apenas armazenamento em memória.
- Código limpo e organizado para fácil entendimento.

---

Teste prático .NET/Angular - ArcadeScore
