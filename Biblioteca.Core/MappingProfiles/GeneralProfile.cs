using AutoMapper;
using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entities;

namespace Biblioteca.Core.MappingProfiles
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Autor, AutorDTO>().ReverseMap();
            CreateMap<Libro, LibroDTO>()
                .ForMember(dest => dest.AutorNombre, opt => opt.MapFrom(src => src.Autor.Nombre))
                .ReverseMap();
        }
    }
}
