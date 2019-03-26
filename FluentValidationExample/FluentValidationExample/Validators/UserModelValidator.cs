using FluentValidation;
using FluentValidationExample.Models;

namespace FluentValidationExample.Validators
{

    public class UserModelValidator : AbstractValidator<UserModelFV>
    {
        public UserModelValidator()
        {
            RuleFor(user => user.UserName)
                .NotNull();

            RuleFor(user => user.Password)
                .NotNull()
                .Length(6,100)
                .WithMessage("The {0} must be at least {2} characters long.");

            RuleFor(user => user.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("The password and confirmation password do not match.");
        }
    }
}