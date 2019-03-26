namespace FluentValidationExample.Validators.Extensions
{
    using FluentValidation;

    public static class CustomValidatorExtensions
    {
        public static IRuleBuilderOptions<T, string> EmailAddressFromDomain<T>(
            this IRuleBuilder<T, string> ruleBuilder,
            string domain)
        {
            return ruleBuilder.SetValidator(new EmailFromDomainValidator(domain));
        }
    }
}