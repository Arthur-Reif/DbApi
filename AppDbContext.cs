using Microsoft.EntityFrameworkCore;
using DbApi.Models;

namespace DbApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(cliente =>
            {
                cliente.ToTable("Tb-clienetes");

                cliente.HasKey(c => c.Id);

                cliente.Property(c => c.Id).HasColumnName("CodiCLi")
                .HasColumnType("varchar(200)");

                cliente.Property(c => c.Email).HasColumnName("email").IsRequired();

                cliente.Property(c => c.Endereco).HasColumnName("endCli").HasColumnType("varchar(200)");
            });
        }
    }
}