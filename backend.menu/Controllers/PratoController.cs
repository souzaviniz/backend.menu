using AutoMapper;
using backend.menu.Data;
using backend.menu.Data.Dto;
using backend.menu.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.menu.Controllers;

[ApiController]
[Route("[controller]")]
public class PratoController : ControllerBase
{
    private AppDbContext _context;
    private IMapper _mapper;

    public PratoController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IEnumerable<ReadPratoDto> RecuperaPrato()
    {
        return _mapper.Map<List<ReadPratoDto>>(_context.Pratos) ;
    }
    
    [HttpPost]
    public CreatePratoDto AdicionaPrato([FromBody] CreatePratoDto pratoDto)
    {
        _context.Add(_mapper.Map<Prato>(pratoDto));
        _context.SaveChanges();
        return pratoDto;
    }
}