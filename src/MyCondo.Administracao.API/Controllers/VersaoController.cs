using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MyCondo.Administracao.API.Controllers;

[ApiController]
[Route("[controller]")]
public class VersaoController : ControllerBase
{
    private readonly ILogger<VersaoController> _logger;

    public VersaoController(ILogger<VersaoController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Obtem versao atual da API
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public string Get()
    {
        try
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }
}
