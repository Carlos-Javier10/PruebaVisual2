using Microsoft.EntityFrameworkCore;
using System;

namespace PruebaDB
{
    public class Class1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= CARLOS ; initial catalog = dvd; trusted_connection = true; ");

            //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        }
    }
}
