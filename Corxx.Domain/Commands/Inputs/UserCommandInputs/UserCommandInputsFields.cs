using Corxx.Shared.Commands;

namespace Corxx.Domain.Commands.Inputs.UserCommandInputs
{
    public abstract class UserCommandInputsFields : CommandInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
