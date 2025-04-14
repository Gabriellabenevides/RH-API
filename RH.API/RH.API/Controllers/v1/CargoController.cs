using MediatR;
using Microsoft.AspNetCore.Mvc;
using RH.Domain.Commands;

namespace RH.API.Controllers.v1
{
    /// <summary>
    /// Controlador responsável por gerenciar as operações relacionadas aos cargos.
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="CargoController"/>.
        /// </summary>
        /// <param name="mediator">Instância do mediador para enviar comandos e consultas.</param>
        public CargoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Endpoint para incluir um novo cargo.
        /// </summary>
        /// <param name="command">Comando contendo os dados do cargo a ser incluído.</param>
        /// <param name="cancellationToken">Token para cancelar a operação, se necessário.</param>
        /// <returns>Retorna um <see cref="IActionResult"/> indicando o sucesso ou falha da operação.</returns>
        /// <response code="200">Se o cargo foi incluído com sucesso.</response>
        /// <response code="400">Se houve falha na inclusão do cargo.</response>
        [HttpPost]
        public async Task<IActionResult> IncluirCargo([FromBody] IncluirCargoCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
