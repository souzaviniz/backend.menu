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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Prato>()
            .HasOne(categoria => categoria.Categoria)
            .WithMany(prato => prato.Pratos)
            .HasForeignKey(prato => prato.IdCategoria);
    }

}