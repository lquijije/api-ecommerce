using Microsoft.EntityFrameworkCore;
using api_ecommerce.Models;

namespace api_ecommerce;

public class ProductContext : DbContext 
{
    public DbSet<tb_productos>? Customers {get; set;}
    public ProductContext (DbContextOptions<ProductContext> options) :base(options) {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tb_productos>(customer => {
            customer.ToTable("tb_productos");
            customer.HasKey(p => p.it_id);
            customer.Property(p => p.it_descripcion);
            customer.Property(p => p.it_precio);           
            customer.Property(p => p.it_estado);
            customer.Property(p => p.it_detalle);
            customer.Property(p => p.it_imagen);
        });
    }
}