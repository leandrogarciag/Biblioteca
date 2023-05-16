using System.Text.Json.Serialization;

namespace Biblioteca.Core.Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int AutorId { get; set; }

        [JsonIgnore]
        public Autor? Autor { get; set; }
    }
}
