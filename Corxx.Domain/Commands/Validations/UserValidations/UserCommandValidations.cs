using Corxx.Domain.Commands.Inputs.UserCommandInputs;
using FluentValidation;

namespace Corxx.Domain.Commands.Validations.UserValidations
{
    public class UserCommandValidations<T> : AbstractValidator<T> where T : UserCommandInputsFields
    {
        protected void ValidateFirstName()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .Length(2, 60).WithMessage("Firstname must have between 2 and 60 characters.");
        }

        protected void ValidateLastName()
        {
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .Length(2, 60).WithMessage("Last name must have between 2 and 60 characters.");
        }

        protected void ValidateEmail()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Firstname is required")
                .EmailAddress().WithMessage("Email is invalid.");
        }
    }
}
