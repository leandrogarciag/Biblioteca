/* using Biblioteca.Core.Entities;
using Biblioteca.Core.DTOs;

namespace Biblioteca.Core.Interfaces
{
    public interface ILibroRepository
    {
        Task<IEnumerable<Libro>> GetLibrosAsync();
        Task<Libro> GetLibroByIdAsync(int id);
        Task AddLibroAsync(Libro libro);
        Task UpdateLibroAsync(Libro libro);
        Task DeleteLibroAsync(int id);
    }
}
 */

using Biblioteca.Core.Entities;
using Biblioteca.Core.DTOs;


namespace Biblioteca.Core.Interfaces

{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetAll();
        Task<Libro> GetById(int id);
        Task Add(Libro libro);
        void Update(Libro libro);
        Task Delete(int id);
    }
}
