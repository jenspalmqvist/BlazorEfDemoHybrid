using BlazorEfDemoHybrid.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEfDemoHybrid.Data
{
	public class GameContext : DbContext
	{
		public GameContext(DbContextOptions<GameContext> options) : base(options) { }

		public DbSet<Game> Games { get; set; }
	}
}
