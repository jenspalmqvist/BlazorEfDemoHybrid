using BlazorEfDemoHybrid.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEfDemoHybrid.Data
{
	public class DataAccess
	{
		private readonly GameContext _gameContext;

		public DataAccess(GameContext gameContext)
		{
			_gameContext = gameContext;
		}

		public async Task<List<Game>> GetAllGames()
		{
			await Task.Delay(500);
			var gamesTask = _gameContext.Games.ToListAsync();
			// Gör andra grejer medan vi hämtar för databaasen är långsam
			var games = await gamesTask;
			return games;
		}

		public async Task AddGame(Game game)
		{
			await _gameContext.Games.AddAsync(game);
			await _gameContext.SaveChangesAsync();
		}

		public async Task<Game?> GetGameById(int id)
		{
			var result = await _gameContext.Games.FindAsync(id);
			return result;
		}

		public async Task UpdateGame(Game game)
		{
			_gameContext.Games.Update(game);
			await _gameContext.SaveChangesAsync();
		}
	}
}
