using AutoMapper;
using backend.menu.Data;
using backend.menu.Data.Dto;
using backend.menu.Models;

namespace backend.menu.Profiles;

public class CategoriaProfile: Profile
{
    public CategoriaProfile()
    {
        CreateMap<CreateCategoriaDto, Categoria>();
        CreateMap<Categoria, ReadCategoriaDto>();
    }
}