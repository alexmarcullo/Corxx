using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Corxx.Domain.Repositories;
using Corxx.Shared.Commands;
using System.Threading.Tasks;

namespace Corxx.Domain.Commands.Handlers
{
    public class UserCommandHandler : ICommandHandler<RegisterUserCommandInput>
    {
        private readonly IUserRepository _repository;

        public UserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }


        public async Task<ICommandOutput> Handler(RegisterUserCommandInput command)
        {
            var user = await _repository.GetByEmailAsync(command.Email);

            return null;
        }
    }
}
