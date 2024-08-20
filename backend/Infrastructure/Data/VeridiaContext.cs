using Microsoft.EntityFrameworkCore;
using VeridiaAPI.Core.Entities;

namespace VeridiaAPI.Infrastructure
{
	public class VeridiaContext : DbContext
	{
		public VeridiaContext(DbContextOptions<VeridiaContext> options)
			: base(options)
		{
		}

		public DbSet<Mundo> Mundo { get; set; }
		public DbSet<Raca> Raca { get; set; }

		// Configure o modelo e outras opções aqui, se necessário
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Configurações adicionais de mapeamento
		}
	}
}
