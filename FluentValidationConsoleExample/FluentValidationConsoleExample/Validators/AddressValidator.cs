using FluentValidation;
using FluentValidationConsoleExample.Models;

namespace FluentValidationConsoleExample.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Postcode)
                .NotNull();

            RuleFor(address => address.Lines)
                .NotNull();

            RuleForEach(address => address.Lines)
                .NotNull();
        }
    }
}