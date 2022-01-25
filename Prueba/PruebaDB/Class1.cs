using Microsoft.EntityFrameworkCore;
using Prueba.Entidades;

namespace PruebaDB
{
    public class Class1 : DbContext
    {
        public DbSet<rental> renatls { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<payment> payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= CARLOS ; initial catalog = dvd; trusted_connection = true; ");

            //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        }
    }
}
