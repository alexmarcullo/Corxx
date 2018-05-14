using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Corxx.Domain.Repositories;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Corxx.Domain.Commands.Handlers
{
    public class UserHandler : INotificationHandler<RegisterUserCommandInput>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RegisterUserCommandInput notification, CancellationToken cancellationToken)
        {
            if (notification.IsValid())
            {
                var user = await _repository.GetByEmailAsync(notification.Email);
            }
        }
    }
}
