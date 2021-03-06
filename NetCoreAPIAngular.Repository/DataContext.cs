

using Microsoft.EntityFrameworkCore;
using NetCoreAPIAngular.Domain.Entities;

namespace NetCoreAPIAngular.Repository
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options){}
        
        
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<RedeSocial> RedeSocials { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.EventoId, PE.PalestranteId});
            
            }
    }
}