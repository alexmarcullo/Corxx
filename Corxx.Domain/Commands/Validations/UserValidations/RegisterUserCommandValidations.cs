using Corxx.Domain.Commands.Inputs.UserCommandInputs;

namespace Corxx.Domain.Commands.Validations.UserValidations
{
    public class RegisterUserCommandValidations : UserCommandValidations<RegisterUserCommandInput>
    {
        public RegisterUserCommandValidations()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateEmail();
        }
    }
}
