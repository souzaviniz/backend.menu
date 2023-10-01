using AutoMapper;
using backend.menu.Data;
using backend.menu.Models;

namespace backend.menu.Profiles;

public class PratoProfile: Profile
{
    public PratoProfile()
    {
        CreateMap<CreatePratoDto, Prato>();
    }
}