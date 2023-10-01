using backend.menu.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.menu.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Prato> Pratos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    
}