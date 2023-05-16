using System.Text.Json.Serialization;

namespace Biblioteca.Core.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Libro> Libros { get; set; }
    }
}
