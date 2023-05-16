using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;

        public LibrosController(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var libros = await _libroRepository.GetAll();
            var librosDTO = _mapper.Map<IEnumerable<LibroDTO>>(libros);
            return Ok(librosDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var libro = await _libroRepository.GetById(id);
            if (libro == null)
            {
                return NotFound();
            }

            var libroDTO = _mapper.Map<LibroDTO>(libro);
            return Ok(libroDTO);
        }

        // ... código anterior ...

        [HttpPost]
        public async Task<IActionResult> Add(LibroDTO libroDTO)
        {
            var libro = _mapper.Map<Libro>(libroDTO);
            await _libroRepository.Add(libro);
            return CreatedAtAction(nameof(GetById), new { id = libro.Id }, libro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, LibroDTO libroDTO)
        {
            if (id != libroDTO.Id)
            {
                return BadRequest();
            }

            var libro = _mapper.Map<Libro>(libroDTO);
            _libroRepository.Update(libro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _libroRepository.Delete(id);
            return NoContent();
        }
    }
}