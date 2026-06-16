using Microsoft.AspNetCore.Mvc;
using FarmaciaInteligenteAPI.src.Services;

namespace FarmaciaInteligenteAPI.src.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicamentoController : ControllerBase
{
    private readonly IMedicamentoService _service;

    public MedicamentoController(IMedicamentoService service)
    {
        _service = service;
    }

    [HttpGet("sugerir")]
    public IActionResult Sugerir([FromQuery] string sintoma)
    {
        var sugestao = _service.ObterSugestao(sintoma);
        return Ok(new { Sintoma = sintoma, Sugestao = sugestao });
    }
}