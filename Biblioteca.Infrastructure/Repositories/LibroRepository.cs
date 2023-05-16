/* using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly BibliotecaContext _context;

        public LibroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Libro>> GetLibrosAsync()
        {
            return await _context.Libros.Include(l => l.Autor).ToListAsync();
        }

        public async Task<Libro> GetLibroByIdAsync(int id)
        {
            return await _context.Libros.Include(l => l.Autor).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddLibroAsync(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLibroAsync(Libro libro)
        {
            _context.Entry(libro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLibroAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
        }
    }
} */


using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;

namespace Biblioteca.Infrastructure.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly BibliotecaContext _context;

        public LibroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task<List<Libro>> GetAll()
        {
            return await _context.Libros.Include(l => l.Autor).ToListAsync();
        }

        public async Task<Libro> GetById(int id)
        {
            return await _context.Libros.Include(l => l.Autor).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task Add(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
        }

        public void Update(Libro libro)
        {
            _context.Entry(libro).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var libro = await GetById(id);
            if (libro != null)
            {
                _context.Libros.Remove(libro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
