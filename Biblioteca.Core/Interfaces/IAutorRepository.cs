/* using Biblioteca.Core.Entities;
using Biblioteca.Core.DTOs;

namespace Biblioteca.Core.Interfaces
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutoresAsync();
        Task<Autor> GetAutorByIdAsync(int id);
        Task <Autor>AddAutorAsync(Autor autor);
        Task UpdateAutorAsync(Autor autor);
        Task DeleteAutorAsync(int id);
    }
} */
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.Interfaces
{
    public interface IAutorRepository
    {
        Task<List<Autor>> GetAll();
        Task<Autor> GetById(int id);
        Task Add(Autor autor);
        void Update(Autor autor);
        Task Delete(int id);
    }
}
