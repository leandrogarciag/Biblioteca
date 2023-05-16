using Microsoft.EntityFrameworkCore;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;

namespace Biblioteca.Infrastructure.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly BibliotecaContext _context;

        public AutorRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<List<Autor>> GetAll()
        {
            return await _context.Autores.Include(a => a.Libros).ToListAsync();
        }

        public async Task<Autor> GetById(int id)
        {
            return await _context.Autores.Include(a => a.Libros).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task Add(Autor autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
        }

        public void Update(Autor autor)
        {
            _context.Entry(autor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var autor = await GetById(id);
            if (autor != null)
            {
                _context.Autores.Remove(autor);
                await _context.SaveChangesAsync();
            }
        }
    }
}