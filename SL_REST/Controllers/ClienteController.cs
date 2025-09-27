using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL_REST.Controllers;

namespace SL_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly BL.Cliente _cliente;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(BL.Cliente cliente) {

            _cliente = cliente;
        };
        //8. Agrega un comentario XML a tu método GET/clientes para que Swagger lo muestre
        /// <summary>
        /// Comentario XML 
        /// </summary>

        [HttpGet]
        [Route("/clientes")]
        [Authorize]
        //6. Implementa en ASP.NET Core un endpoint GET/clientes que devuelva una
        //lista fija de clientes en JSON(puedes integrarlo en el ejercicio del final).
        public IActionResult GetClientes() {

            var result = _cliente.GetClientes();
            if (result.Correct)
            {
                return Ok(result.Object);
            }
            else {
                return NotFound(result);
            }

        }

    }
}





/// <summary>
///
/// </summary>
/// <param name="logger"></param>
public WeatherForecastController(ILogger<ClienteController> logger)
{
    _logger = logger;
}
/// <summary>
/// Gets weather forecast information
/// </summary>
/// <param name="parameter1">This is parameter 1</param>
/// <param name="parameter2">This is parameter 2</param>