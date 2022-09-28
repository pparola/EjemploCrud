using Microsoft.EntityFrameworkCore;

namespace EjemploCrud.Modelo
{

    public class ArticulosContext : DbContext
    {

        public ArticulosContext(DbContextOptions<ArticulosContext> options) : base(options)
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Articulo> Articulos { get; set; }

    }

}
