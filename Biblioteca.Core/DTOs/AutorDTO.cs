
namespace Biblioteca.Core.DTOs
{
    public class AutorDTO
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<LibroDTO>? Libros { get; set; }
    }
}