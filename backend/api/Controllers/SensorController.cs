using System;
using System.Threading.Tasks;
using domain.entities;
using domain.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorController : ControllerBase
    {
        private readonly ILogger<SensorController> _logger;
        private readonly ISensorRepository _sensorRepository;

        public SensorController(ILogger<SensorController> logger, ISensorRepository sensorRepository) 
        {
            this._logger = logger;
            this._sensorRepository = sensorRepository;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Sensor), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Sensor), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Sensor), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(Sensor model)
        {
            if(model == null || !model.ValidObject())
                return BadRequest(model);

            try{
                model = await _sensorRepository.AddAsync(model);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro: " + ex.Message);
            }

            return Ok(model);
        }
    }
}
