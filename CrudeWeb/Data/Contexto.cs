using CrudeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudeWeb.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario
        {get; set;}
    }
}
