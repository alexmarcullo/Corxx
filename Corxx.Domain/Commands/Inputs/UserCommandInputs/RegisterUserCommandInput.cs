namespace Corxx.Domain.Commands.Inputs.UserCommandInputs
{
    public class RegisterUserCommandInput : UserCommandInputsFields
    {
        public RegisterUserCommandInput(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override bool IsValid()
        {
            return true;    
        }
    }
}
