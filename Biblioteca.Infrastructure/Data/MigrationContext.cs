using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.Infrastructure.Data
{
    public class DesignTimeBibliotecaContextFactory : IDesignTimeDbContextFactory<BibliotecaContext>
    {
        public BibliotecaContext CreateDbContext(string[] args)
        {
            // Construir configuración
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()+ "\\..\\Biblioteca.API")
                .AddJsonFile("appsettings.json")
                .Build();

            // Crear options builder
            var optionsBuilder = new DbContextOptionsBuilder<BibliotecaContext>();

            // Obtener cadena de conexión
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Usar SQL Server y la cadena de conexión
            optionsBuilder.UseSqlServer(connectionString);

            return new BibliotecaContext(optionsBuilder.Options);
        }
    }
}
