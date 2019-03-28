using System;
using FluentValidation.TestHelper;
using FluentValidationConsoleExample.Constants;
using FluentValidationConsoleExample.Validators;
using Xunit;

namespace FluentValidationConsoleExample.Validators.Tests
{
    public class CustomerValidatorTests
    {
        private CustomerValidator validator;

        public CustomerValidatorTests()
        {
            validator = new CustomerValidator();
        }

        [Fact]
        public void CustomerValidator_WhenUsernameIsNull_ShouldHaveError()
        {
            validator
                .ShouldHaveValidationErrorFor(customer => customer.Username, null as string);
        }

        [Fact]
        public void CustomerValidator_WhenUsernameIsNull_ShouldHaveError_WithMessage()
        {
            validator
                .ShouldHaveValidationErrorFor(customer => customer.Username, null as string)
                .WithErrorMessage(ErrorMessages.NullUsernameErrorMessage);
        }

        [Fact]
        public void CustomerValidator_WhenUsernameIsFoo_ShouldHaveError()
        {
            validator
                .ShouldHaveValidationErrorFor(customer => customer.Username, "foo");
        }

        [Fact]
        public void CustomerValidator_WhenUsernameIsFoo_ShouldHaveError_WithMessage()
        {
            validator
                .ShouldHaveValidationErrorFor(customer => customer.Username, "foo")
                .WithErrorMessage(ErrorMessages.FooUsernameErrorMessage);
        }

        [Fact]
        public void CustomerValidator_WhenUsernameIsNotNull_ShouldNotHaveError()
        {
            validator
                .ShouldNotHaveValidationErrorFor(customer => customer.Username, "Grazyna");
        }

        [Fact]
        public void CustomerValidator_WhenAddressPostCodeIsNull_ShouldHaveChildValidator()
        {
            validator.ShouldHaveChildValidator(customer => customer.Address, typeof(AddressValidator));
        }
    }
}
