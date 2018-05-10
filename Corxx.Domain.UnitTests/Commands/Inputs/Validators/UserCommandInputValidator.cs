using Corxx.Domain.Commands.Validations.UserValidations;
using Corxx.Domain.UnitTests.Commands.Inputs.CommandInputs;

namespace Corxx.Domain.UnitTests.Commands.Inputs.Validators
{
    public class UserCommandInputValidator : UserCommandValidations<UserCommandInputs>
    {
        public UserCommandInputValidator()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateEmail();
        }
    }
}
