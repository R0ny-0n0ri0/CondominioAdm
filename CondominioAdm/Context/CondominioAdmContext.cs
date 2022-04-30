using CondominioAdm.Models;
using Microsoft.EntityFrameworkCore;

namespace CondominioAdm.Context
{
    public class CondominioAdmContext : DbContext
    { 
        public CondominioAdmContext(DbContextOptions<CondominioAdmContext> options ) : base(options)
        { }
        public DbSet<Models.Condominio> Comdominios { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Morador> Moradores { get; set;}

    }
}
