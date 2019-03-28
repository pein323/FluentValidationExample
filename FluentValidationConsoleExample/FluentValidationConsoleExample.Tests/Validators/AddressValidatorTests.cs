using FluentValidation.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace FluentValidationConsoleExample.Validators.Tests
{
    public class AddressValidatorTests
    {
        private AddressValidator validator;

        public AddressValidatorTests()
        {
            validator = new AddressValidator();
        }

        [Fact]
        public void AddressValidator_WhenPostcodeIsNull_ShouldHaveError()
        {
            validator.ShouldHaveValidationErrorFor(address => address.Postcode, null as string);
        }

        [Fact]
        public void AddressValidator_WhenAddressIsNull_ShouldHaveError()
        {
            validator.ShouldHaveValidationErrorFor(address => address.Lines, null as List<string>);
        }

        [Fact]
        public void AddressValidator_WhenAddressLinesAreNull_ShouldHaveError()
        {
            validator.ShouldHaveValidationErrorFor(address => address.Lines, new List<string>() { null });
        }

        [Fact]
        public void AddressValidator_WhenAddressLinesHaveValues_ShouldNotHaveError()
        {
            validator.ShouldNotHaveValidationErrorFor(address => address.Lines, new List<string>() { "Line one", "Line two" });
        }
    }
}