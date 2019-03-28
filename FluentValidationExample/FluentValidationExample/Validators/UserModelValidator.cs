using System;
using System.Linq;
using FluentValidation;
using FluentValidation.Validators;
using FluentValidationExample.Models;
using FluentValidationExample.Validators.Extensions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
                .MinimumLength(6)
                .WithMessage("The Password must be at least {0} characters long.")
                .MaximumLength(10)
                .WithMessage("The Password must be less than {0} characters long.");

            RuleFor(user => user.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("The password and confirmation password do not match.");

            RuleFor(user => user.EmailAddress)
                .NotNull()
                .EmailAddress()
                .EmailAddressFromDomain("pgs-soft.pl");

            RuleForEach(user => user.AddressLines)
                .NotNull()
                .WithMessage("Adress line should not be null");


        }
    }

    public class EmailFromDomainValidator : PropertyValidator
    {
        private readonly string _domain;

        public EmailFromDomainValidator(string domain) 
            : base(String.Concat("Provided email address {PropertyValue} is not from domain ", $"{domain}"))
        {
            _domain = domain;
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            if (context.PropertyValue == null) return false;

            var split = (context.PropertyValue as string).Split('@');
            if (split.Length == 2 && split[1].ToLower().Equals(_domain)) return true;

            return false;
        }
    }
}