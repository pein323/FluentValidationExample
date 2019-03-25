using FluentValidation;
using FluentValidationExample.Models;

namespace FluentValidationExample.Validators
{

    public class UserModelValidator : AbstractValidator<UserModelFV>
    {
        public UserModelValidator()
        {
            RuleFor(user => user.UserName).NotNull();
        }
    }
}