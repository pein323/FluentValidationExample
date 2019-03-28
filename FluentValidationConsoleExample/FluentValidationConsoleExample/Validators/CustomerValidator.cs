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

            RuleFor(customer => customer.Address)
                .SetValidator(new AddressValidator());

            //RuleFor(customer => customer.Address.Postcode)
            //    .NotNull()
            //    .When(customer => customer.Address != null);
        }
    }
}