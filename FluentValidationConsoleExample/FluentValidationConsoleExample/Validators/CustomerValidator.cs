using FluentValidation;
using FluentValidationConsoleExample.Constants;
using FluentValidationConsoleExample.Models;

namespace FluentValidationConsoleExample.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Username)
                .NotNull()
                .WithMessage(ErrorMessages.NullUsernameErrorMessage)
                .NotEqual("foo")
                .WithMessage(ErrorMessages.FooUsernameErrorMessage);
        }
    }
}