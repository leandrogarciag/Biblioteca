// LibrosAutores.Infrastructure/Data/LibrosAutoresContext.cs
using Biblioteca.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Libros)
                .WithOne(b => b.Autor)
                .HasForeignKey(b => b.AutorId);
        }
    }
}
