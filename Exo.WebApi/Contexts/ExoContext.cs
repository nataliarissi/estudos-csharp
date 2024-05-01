using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = ExoApi; Initial Catalog = GerenciamentoTarefa; User ID = sa; Password = Natalia@123");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}