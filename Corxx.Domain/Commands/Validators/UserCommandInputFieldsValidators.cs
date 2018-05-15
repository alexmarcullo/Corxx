using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using Flunt.Validations;

namespace Corxx.Domain.Commands.Validators
{
    public static class UserCommandInputFieldsValidators
    {
        public static void ValidateFirstName(this UserCommandInputsFields command)
        {
            command.AddNotifications(new Contract()
                .IsNotNullOrEmpty(command.FirstName, "FirstName", "First name is required")
                .HasMinLen(command.FirstName, 2, "FirstName", "Firstname must have between 2 and 60 characters.")
                .HasMaxLen(command.FirstName, 60, "FirstName", "Firstname must have between 2 and 60 characters."));
        }

        public static void ValidateLastName(this UserCommandInputsFields command)
        {
            command.AddNotifications(new Contract()
                .IsNotNullOrEmpty(command.LastName, "LastName", "Last name is required")
                .HasMinLen(command.LastName, 2, "LastName", "Last name must have between 2 and 60 characters.")
                .HasMaxLen(command.LastName, 60, "LastName", "Last name must have between 2 and 60 characters."));
        }

        public static void ValidateEmail(this UserCommandInputsFields command)
        {
            command.AddNotifications(new Contract()
                .IsNotNullOrEmpty(command.Email, "Email", "Email is required")
                .IsEmail(command.Email, "Email", "Email is invalid."));
        }
    }
}
