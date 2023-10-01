using AutoMapper;
using backend.menu.Data;
using backend.menu.Data.Dto;
using backend.menu.Models;

namespace backend.menu.Profiles;

public class PratoProfile: Profile
{
    public PratoProfile()
    {
        CreateMap<CreatePratoDto, Prato>();
        CreateMap<Prato, ReadPratoDto>();
    }
}