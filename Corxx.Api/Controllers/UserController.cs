using Corxx.Domain.Commands.Handlers;
using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Corxx.Infra;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Corxx.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class UserController : BaseController
    {
        private readonly UserCommandHandler _handler;

        public UserController(IUnitOfWork unitOfWork,UserCommandHandler handler)
            : base(unitOfWork)
        {
            _handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterUserCommandInput command)
        {
            return await Response(
                await _handler.Handler(command),
                _handler.Notifications.ToList());
        }
    }
}