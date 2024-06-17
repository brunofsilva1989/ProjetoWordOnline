using Microsoft.EntityFrameworkCore;
using ProjetoWordOnline.Models;

namespace ProjetoWordOnline.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        
        public DbSet<Documento> Documentos { get; set; }

    }
}
