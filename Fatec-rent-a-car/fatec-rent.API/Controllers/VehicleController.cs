using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fatec_rent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVeiculoRepository _veiculoRepository;

        public VehicleController(ILogger<VehicleController> logger, IVeiculoRepository veiculoRepository)
        {
            _logger = logger;
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> Get()
        {
            try
            {
                _logger.LogInformation("Get executado com sucesso");
                var veiculos = await _veiculoRepository.GetAll();
                return Ok(veiculos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter veículos");
                return StatusCode(500, "Erro interno do servidor");
            }
        }
    }
}
