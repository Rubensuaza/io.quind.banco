using io.quind.banco.dominio.Servicios;
using io.quind.banco.dto;
using Microsoft.AspNetCore.Mvc;

namespace io.quind.banco.app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _cliente;

        public ClienteController(IClienteServices cliente)
        {
            _cliente = cliente;
        }

        [HttpGet("{id:int}")]
        public IActionResult getCliente(int id)
        {
            try
            {
                var oCliente = _cliente.findById(id);
                if (oCliente == null)
                {
                    return NotFound();
                }
                var oClienteDto = ClienteResponseDTO.of(oCliente);
                return Ok(oClienteDto);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
