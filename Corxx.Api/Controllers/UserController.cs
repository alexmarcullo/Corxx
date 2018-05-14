using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Corxx.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async void Post([FromBody] RegisterUserCommandInput command)
        {
            await _mediator.Publish(command);
        }
    }
}