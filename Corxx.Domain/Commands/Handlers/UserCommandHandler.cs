using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Corxx.Domain.Entities;
using Corxx.Domain.Repositories;
using Corxx.Domain.Services;
using Corxx.Domain.ValueObjects;
using Corxx.Shared.Commands;
using Flunt.Notifications;
using System.Threading.Tasks;

namespace Corxx.Domain.Commands.Handlers
{
    public class UserCommandHandler : Notifiable, 
        ICommandHandler<RegisterUserCommandInput>
    {
        private readonly IUserRepository _repository;
        private readonly IEmailService _emailService;

        public UserCommandHandler(IUserRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }


        public async Task<ICommandOutput> Handler(RegisterUserCommandInput command)
        {
            if (!command.IsValid())
            {
                AddNotifications(command.Notifications);
                return null;
            }
            var user = await _repository.GetByEmailAsync(command.Email);

            if (user != null)
                AddNotification("Email", "This email is already registered.");

            var name = new Name(command.FirstName, command.LastName);
            var email = new Email(command.Email);

            user = new User(email, name);

            await _repository.SaveAsync(user);

            return null;
        }
    }
}
