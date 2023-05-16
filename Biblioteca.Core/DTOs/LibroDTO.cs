using System.Text.Json.Serialization;

namespace Biblioteca.Core.DTOs
{
    public class LibroDTO
    {
        public int? Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int? AutorId { get; set; }
        public string? AutorNombre { get; set; }
    }
}