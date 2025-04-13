using MediatR;
using Microsoft.AspNetCore.Mvc;
using RH.Domain.Commands;
using RH.Domain.Shareds.Notifications;
using RH.Domain.ViewModel;

namespace RH.API.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class ColaboradorController : ControllerBase
{
    private readonly IMediator _mediator;

    public ColaboradorController(IMediator mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> IncluirColaborador([FromBody] IncluirColaboradorCommand command, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(command, cancellationToken);

        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
