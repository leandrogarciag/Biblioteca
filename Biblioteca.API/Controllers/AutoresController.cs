using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;
using Biblioteca.Core.Interfaces;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;

        public AutoresController(IAutorRepository autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var autores = await _autorRepository.GetAll();
            var autoresDTO = _mapper.Map<IEnumerable<AutorDTO>>(autores);
            return Ok(autoresDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var autor = await _autorRepository.GetById(id);
            if (autor == null)
            {
                return NotFound();
            }

            var autorDTO = _mapper.Map<AutorDTO>(autor);
            return Ok(autorDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AutorDTO autorDTO)
        {
            var autor = _mapper.Map<Autor>(autorDTO);
            await _autorRepository.Add(autor);
            return CreatedAtAction(nameof(GetById), new { id = autor.Id }, autor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AutorDTO autorDTO)
        {
            if (id != autorDTO.Id)
            {
                return BadRequest();
            }

            var autor = _mapper.Map<Autor>(autorDTO);
            _autorRepository.Update(autor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _autorRepository.Delete(id);
            return NoContent();
        }
    }
}
