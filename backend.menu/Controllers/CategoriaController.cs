using AutoMapper;
using backend.menu.Data;
using backend.menu.Data.Dto;
using backend.menu.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.menu.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriaController: ControllerBase
{
    private AppDbContext _context;
    private IMapper _mapper;

    public CategoriaController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public ReadCategoriaDto AdicionaCategoria([FromBody] CreateCategoriaDto categoriaDto)
    {
        var categoria = _mapper.Map<Categoria>(categoriaDto);
        _context.Add(categoria);
        _context.SaveChanges();
        return _mapper.Map<ReadCategoriaDto>(categoria);   
    }

    [HttpGet]
    public List<ReadCategoriaDto> ObterCategorias()
    {
        var categorias = _context.Categorias;
        var map = _mapper.Map<List<ReadCategoriaDto>>(categorias);
        return map;
    }
}