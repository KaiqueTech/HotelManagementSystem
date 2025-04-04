using Microsoft.EntityFrameworkCore;
using Modelo.DTO;

namespace Conexao
{
    public class HotelContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            if (!options.IsConfigured)
            {
                var conexaoStr = options.UseSqlServer("Server=DESKTOP-T2VQIR2\\SQLEXPRESS;Database=dbHotel;User Id=sa;Password=1234;");
            }
            
        }

        public DbSet<FuncionarioDTO> funcionarioDTOs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FuncionarioDTO>().ToTable("funcionarios");
        }
    }
}
